using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;

public class LuaMain : MonoBehaviour
{
    private LuaState luaState = null;
    private LuaFunction luaFunc;
    void Start()
    {
        new LuaResLoader();
        luaState = new LuaState();
        luaState.Start();
        LuaBinder.Bind(luaState);
        luaState.DoFile("Main.lua");
        CallFunc("Main.Start");
        
    }

    private void Update()
    {
        CallFunc("Main.Update");
    }

    void CallFunc(string func)
    {
        luaFunc = luaState.GetFunction(func);
        luaFunc.Call();
    }
}
