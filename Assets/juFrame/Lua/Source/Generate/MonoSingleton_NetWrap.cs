﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MonoSingleton_NetWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MonoSingleton<Net>), typeof(UnityEngine.MonoBehaviour), "MonoSingleton_Net");
		L.RegFunction("Update", Update);
		L.RegFunction("Reset", Reset);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MonoSingleton<Net> obj = (MonoSingleton<Net>)ToLua.CheckObject(L, 1, typeof(MonoSingleton<Net>));
			obj.Update();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			MonoSingleton<Net> obj = (MonoSingleton<Net>)ToLua.CheckObject(L, 1, typeof(MonoSingleton<Net>));
			obj.Reset();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, MonoSingleton<Net>.Instance);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
