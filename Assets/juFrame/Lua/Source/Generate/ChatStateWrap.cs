﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ChatStateWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(ChatState));
		L.RegVar("MainChat", get_MainChat, null);
		L.RegVar("MiniChatMenu", get_MiniChatMenu, null);
		L.RegVar("MiniChat2", get_MiniChat2, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MainChat(IntPtr L)
	{
		ToLua.Push(L, ChatState.MainChat);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MiniChatMenu(IntPtr L)
	{
		ToLua.Push(L, ChatState.MiniChatMenu);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MiniChat2(IntPtr L)
	{
		ToLua.Push(L, ChatState.MiniChat2);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		ChatState o = (ChatState)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

