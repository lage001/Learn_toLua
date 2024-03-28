using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using LuaInterface;
public class TestEditor
{
    static  LuaFunction luaFunc;
    static LuaState luaState;
    [MenuItem("Cmd/TestLua")]
    public static void TestLua()
    {
        new LuaResLoader();
        luaState = new LuaState();
        luaState.Start();
        LuaBinder.Bind(luaState);
        luaState.DoFile("TestLua.lua");
        //CallFunc("A.C");
    }

    public static void CallFunc(string func)
    {
        luaFunc = luaState.GetFunction(func);
        luaFunc.Call();
    }
}
