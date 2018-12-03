using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


/// <summary>
/// 协调Model与View的交互 
///  一个控制器对应一个事件, 当事件传递来时, 会动态创建一个控制器.
/// </summary>
public abstract class Controller 
{
    //获取模型


    protected T GetModel<T>() where T:Model
    {
        return MVC.GetModel<T>() as T;
    }
    //获取视图
    protected T GetView<T>() where T : View
    {
        return MVC.GetView <T>() as T;
    }

    //注册
    protected void RegisterModel(Model model)
    {
        MVC.RegisterModel(model);
    }

    protected void RegisterView(View view)
    {
        MVC.RegisterView(view);
    }

    protected void RegisterController(string eventName, Type type)
    {
        MVC.RegisterController(eventName, type);
    }

    //执行系统消息

    public abstract void Execute(object data); 

}