﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UIExtendTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UIExtendType));
		L.RegVar("NONE", get_NONE, null);
		L.RegVar("MOVEINOUT", get_MOVEINOUT, null);
		L.RegVar("BLACKMASK", get_BLACKMASK, null);
		L.RegVar("BLACKCANCELMASK", get_BLACKCANCELMASK, null);
		L.RegVar("TRANSMASK", get_TRANSMASK, null);
		L.RegVar("TRANSCANCELMASK", get_TRANSCANCELMASK, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_NONE(IntPtr L)
	{
		ToLua.Push(L, UIExtendType.NONE);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MOVEINOUT(IntPtr L)
	{
		ToLua.Push(L, UIExtendType.MOVEINOUT);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BLACKMASK(IntPtr L)
	{
		ToLua.Push(L, UIExtendType.BLACKMASK);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BLACKCANCELMASK(IntPtr L)
	{
		ToLua.Push(L, UIExtendType.BLACKCANCELMASK);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TRANSMASK(IntPtr L)
	{
		ToLua.Push(L, UIExtendType.TRANSMASK);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_TRANSCANCELMASK(IntPtr L)
	{
		ToLua.Push(L, UIExtendType.TRANSCANCELMASK);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UIExtendType o = (UIExtendType)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

