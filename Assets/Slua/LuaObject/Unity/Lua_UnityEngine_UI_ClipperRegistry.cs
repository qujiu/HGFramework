﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ClipperRegistry : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Cull(IntPtr l) {
		try {
			UnityEngine.UI.ClipperRegistry self=(UnityEngine.UI.ClipperRegistry)checkSelf(l);
			self.Cull();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Register_s(IntPtr l) {
		try {
			UnityEngine.UI.IClipper a1;
			checkType(l,1,out a1);
			UnityEngine.UI.ClipperRegistry.Register(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Unregister_s(IntPtr l) {
		try {
			UnityEngine.UI.IClipper a1;
			checkType(l,1,out a1);
			UnityEngine.UI.ClipperRegistry.Unregister(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_instance(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,UnityEngine.UI.ClipperRegistry.instance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.ClipperRegistry");
		addMember(l,Cull);
		addMember(l,Register_s);
		addMember(l,Unregister_s);
		addMember(l,"instance",get_instance,null,false);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.ClipperRegistry));
	}
}
