﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_ScrollRect_MovementTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.UI.ScrollRect.MovementType));
		L.RegVar("Unrestricted", get_Unrestricted, null);
		L.RegVar("Elastic", get_Elastic, null);
		L.RegVar("Clamped", get_Clamped, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Unrestricted(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.UI.ScrollRect.MovementType.Unrestricted);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Elastic(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.UI.ScrollRect.MovementType.Elastic);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Clamped(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.UI.ScrollRect.MovementType.Clamped);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.UI.ScrollRect.MovementType o = (UnityEngine.UI.ScrollRect.MovementType)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

