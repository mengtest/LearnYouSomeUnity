function CollectProcessView ()
	local CollectProcess = {};
	local this = nil;

	local collectName = nil;
	local collectProcess = nil;
	local foreground = nil;
	local background = nil;

	local SetMode = nil;
	local UpdateProgress = nil;
	local UpdateProcessText = nil;
	--内部数据
	local bProcessOn = false;
	local nNpcSid = 0;
	local nNpcId = 0;
	local fNeedTime  = 0;
	local fCostTime  = 0;
	local fProgress  = 0;
	local ProcessPicture = {"dk_jindu_1", "dk_jindu_2"};
	local ProcessColor = {Color.New(1, 1, 1), Color.New(255 / 255, 64 / 255, 64 / 255)}
	local callBack = nil;
	local coolDown = 2;	--在上次采集被打断后的1s内不会开始新的采集
	local lastBreakTime = 0;
	local effect = nil;

	function CollectProcess.Start ()
		this = CollectProcess.this;
		collectName = CollectProcess.collectName;
		collectProcess = CollectProcess.collectProcess;
		foreground = CollectProcess.foreground;
		background = CollectProcess.background;
		effect = this:LoadUIEffect(this.gameObject, "caiji", true, true);
		effect.transform:SetParent(foreground.transform)
		effect.transform.localScale = Vector3.one;
		effect.transform.localPosition = Vector3.zero;
		this.gameObject:SetActive(false);
		SetPort("stop_collect", CollectProcess.BreakCollect);
		CollectProcess.setEffectPos(0);
	end


	function CollectProcess.setEffectPos(value)
		effect:SetActive(true);
		local rt = effect:GetComponent("RectTransform");
		local min = -151;
		local max = 151;
		rt.anchoredPosition = Vector3.New(min + (max - min) * value, 0, 0);
		-- if value == 1 then
			-- collectName:DOFade(1, 0, 1);
			-- collectProcess:DOFade(1, 0, 1);
			-- foreground:GetComponent("Image"):DOFade(0, 1);
			-- background:GetComponent("Image"):DOFade(0, 1);
		-- end
	end

	function CollectProcess.CheckCoolDown()
		if TimerManager.GetServerNowMillSecond() - lastBreakTime >= coolDown * 1000 then
			return true;
		else
			return false;
		end
	end

	function CollectProcess.StartCollect(npcSid, npcId, needTime, collectText , func)
		this.gameObject:SetActive(true);
		--设置所需的时间并重置已经经过的时间
		nNpcSid = npcSid;
		nNpcId = npcId;
		fNeedTime = needTime;
		fCostTime = 0;
		--注册完成后的回调
		callBack = func;
		--设置计时状态
		bProcessOn = true;
        --设置进度条的颜色和字体颜色
        SetMode(true);
        --设置采集时显示的文本
        collectName.text = collectText;
        collectProcess.text = "0%";
  --       collectName:DOFade(0, 1, 0);
		-- collectProcess:DOFade(0, 1, 0);
        UpdateProgress(0);
	end

	SetMode = function(bGoing)    
        if bGoing == true then
            --进度条使用的图片
            foreground.sprite = ProcessPicture[1];        
            --两段文本的颜色
            collectName.textColor = ProcessColor[1];
            collectProcess.textColor = ProcessColor[1];
        else       
            foreground.sprite = ProcessPicture[2];
            --两段文本的颜色
            collectName.textColor = ProcessColor[2];
            collectProcess.textColor = ProcessColor[2];
        end
    end

    UpdateProgress = function(progress)
    	foreground.fillAmount = progress;
    	CollectProcess.setEffectPos(progress);
	end

    UpdateProcessText = function(progress)
    	local precent = math.floor(progress * 100);
    	if precent > 100 then
    		precent = 100;
    	end
    	if precent < 0 then
    		precent = 0;
    	end
    	local str = precent.."%";
    	collectProcess.text = str;
	end


	CollectProcess.StopCollect = function()

		if nNpcSid ~= 0 and nNpcId ~= 0 then
			-- client.task.breakCollectResBySid(nNpcSid, nNpcId);
			nNpcSid = 0;
			nNpcId = 0;
			lastBreakTime = TimerManager.GetServerNowMillSecond();
			this.gameObject:SetActive(false);
		end
	end

	--因为移动或攻击打断读条
	CollectProcess.BreakCollect = function()
		if not client.collectProcess.isCollect() then
			return;
		end
		effect:SetActive(false);
		SetMode(false);
		fCostTime = 0;
		collectProcess.text = "中断";
		bProcessOn = false;
		this:Delay(1, function()
			this.gameObject:SetActive(false);
		end)
		lastBreakTime = TimerManager.GetServerNowMillSecond();
	end


	function CollectProcess.ManualUpdate(fProgress)
		if bProcessOn then
			if fProgress >= 1 then
				fProgress = 1
			end
			UpdateProgress(fProgress);
			UpdateProcessText(fProgress);

			--这时读条已经完成，执行回调
			if fProgress == 1 then
				bProcessOn = false;
				fCostTime = 0;
				this.gameObject:SetActive(false);
			end
		end
	end

	function CollectProcess.isCollect()
		return bProcessOn;
	end

	client.collectProcess = CollectProcess;
	client._StopCollect = CollectProcess.StopCollect;

	return CollectProcess;
end

function CreateCollectProcess()
	PanelManager:CreatePanel('CollectProcess', WindowLayer.UNDER_PANEL);
end
