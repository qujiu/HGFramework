﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Assertions_Comparers_FloatComparer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Assertions.Comparers.FloatComparer o;
			if(argc==1){
				o=new UnityEngine.Assertions.Comparers.FloatComparer();
				pushValue(l,o);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(bool))){
				System.Boolean a1;
				checkType(l,2,out a1);
				o=new UnityEngine.Assertions.Comparers.FloatComparer(a1);
				pushValue(l,o);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(float))){
				System.Single a1;
				checkType(l,2,out a1);
				o=new UnityEngine.Assertions.Comparers.FloatComparer(a1);
				pushValue(l,o);
				return 1;
			}
			else if(argc==3){
				System.Single a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				o=new UnityEngine.Assertions.Comparers.FloatComparer(a1,a2);
				pushValue(l,o);
				return 1;
			}
			LuaDLL.luaL_error(l,"New object failed.");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AreEqual_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Assertions.Comparers.FloatComparer.AreEqual(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AreEqualRelative_s(IntPtr l) {
		try {
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			var ret=UnityEngine.Assertions.Comparers.FloatComparer.AreEqualRelative(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_kEpsilon(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Assertions.Comparers.FloatComparer.kEpsilon);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_s_ComparerWithDefaultTolerance(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Assertions.Comparers.FloatComparer.s_ComparerWithDefaultTolerance);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Assertions.Comparers.FloatComparer");
		addMember(l,AreEqual_s);
		addMember(l,AreEqualRelative_s);
		addMember(l,"kEpsilon",get_kEpsilon,null,false);
		addMember(l,"s_ComparerWithDefaultTolerance",get_s_ComparerWithDefaultTolerance,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Assertions.Comparers.FloatComparer));
	}
}
