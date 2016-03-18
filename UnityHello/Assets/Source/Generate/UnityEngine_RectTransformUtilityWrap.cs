﻿using System;
using LuaInterface;

public class UnityEngine_RectTransformUtilityWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.RectTransformUtility), typeof(System.Object));
		L.RegFunction("RectangleContainsScreenPoint", RectangleContainsScreenPoint);
		L.RegFunction("PixelAdjustPoint", PixelAdjustPoint);
		L.RegFunction("PixelAdjustRect", PixelAdjustRect);
		L.RegFunction("ScreenPointToWorldPointInRectangle", ScreenPointToWorldPointInRectangle);
		L.RegFunction("ScreenPointToLocalPointInRectangle", ScreenPointToLocalPointInRectangle);
		L.RegFunction("ScreenPointToRay", ScreenPointToRay);
		L.RegFunction("WorldToScreenPoint", WorldToScreenPoint);
		L.RegFunction("CalculateRelativeRectTransformBounds", CalculateRelativeRectTransformBounds);
		L.RegFunction("FlipLayoutOnAxis", FlipLayoutOnAxis);
		L.RegFunction("FlipLayoutAxes", FlipLayoutAxes);
		L.RegFunction("New", _CreateUnityEngine_RectTransformUtility);
		L.RegFunction("__tostring", Lua_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_RectTransformUtility(IntPtr L)
	{
		return LuaDLL.tolua_error(L, "UnityEngine.RectTransformUtility class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RectangleContainsScreenPoint(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UnityEngine.RectTransform), typeof(UnityEngine.Vector2)))
			{
				UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.ToObject(L, 1);
				UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 2);
				bool o = UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 3 && ToLua.CheckTypes(L, 1, typeof(UnityEngine.RectTransform), typeof(UnityEngine.Vector2), typeof(UnityEngine.Camera)))
			{
				UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.ToObject(L, 1);
				UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 2);
				UnityEngine.Camera arg2 = (UnityEngine.Camera)ToLua.ToObject(L, 3);
				bool o = UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(arg0, arg1, arg2);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.tolua_error(L, "invalid arguments to method: UnityEngine.RectTransformUtility.RectangleContainsScreenPoint");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PixelAdjustPoint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 1);
			UnityEngine.Transform arg1 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
			UnityEngine.Canvas arg2 = (UnityEngine.Canvas)ToLua.CheckUnityObject(L, 3, typeof(UnityEngine.Canvas));
			UnityEngine.Vector2 o = UnityEngine.RectTransformUtility.PixelAdjustPoint(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PixelAdjustRect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			UnityEngine.Canvas arg1 = (UnityEngine.Canvas)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Canvas));
			UnityEngine.Rect o = UnityEngine.RectTransformUtility.PixelAdjustRect(arg0, arg1);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScreenPointToWorldPointInRectangle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 2);
			UnityEngine.Camera arg2 = (UnityEngine.Camera)ToLua.CheckUnityObject(L, 3, typeof(UnityEngine.Camera));
			UnityEngine.Vector3 arg3;
			bool o = UnityEngine.RectTransformUtility.ScreenPointToWorldPointInRectangle(arg0, arg1, arg2, out arg3);
			LuaDLL.lua_pushboolean(L, o);
			ToLua.Push(L, arg3);
			return 2;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScreenPointToLocalPointInRectangle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 2);
			UnityEngine.Camera arg2 = (UnityEngine.Camera)ToLua.CheckUnityObject(L, 3, typeof(UnityEngine.Camera));
			UnityEngine.Vector2 arg3;
			bool o = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(arg0, arg1, arg2, out arg3);
			LuaDLL.lua_pushboolean(L, o);
			ToLua.Push(L, arg3);
			return 2;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ScreenPointToRay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Camera arg0 = (UnityEngine.Camera)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Camera));
			UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 2);
			UnityEngine.Ray o = UnityEngine.RectTransformUtility.ScreenPointToRay(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WorldToScreenPoint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Camera arg0 = (UnityEngine.Camera)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Camera));
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector2 o = UnityEngine.RectTransformUtility.WorldToScreenPoint(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateRelativeRectTransformBounds(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && ToLua.CheckTypes(L, 1, typeof(UnityEngine.Transform)))
			{
				UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Bounds o = UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(UnityEngine.Transform)))
			{
				UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 1);
				UnityEngine.Transform arg1 = (UnityEngine.Transform)ToLua.ToObject(L, 2);
				UnityEngine.Bounds o = UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.tolua_error(L, "invalid arguments to method: UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FlipLayoutOnAxis(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
			bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
			UnityEngine.RectTransformUtility.FlipLayoutOnAxis(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FlipLayoutAxes(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.RectTransform arg0 = (UnityEngine.RectTransform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.RectTransform));
			bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
			UnityEngine.RectTransformUtility.FlipLayoutAxes(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}
}
