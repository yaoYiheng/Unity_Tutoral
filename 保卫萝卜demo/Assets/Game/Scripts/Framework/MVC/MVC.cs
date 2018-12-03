using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

 /// <summary>
/// 保存MVC各个部分以及处理事件的分发
/// </summary>

public static class MVC 
{
    // 存储MVC

    // 名字--模型
    public static Dictionary<string, Model> Models = new Dictionary<string, Model>();
    // 名字--视图
    public static Dictionary<string, View> Views = new Dictionary<string, View>();
    // 存储的并不是控制器的实例, 因为控制器是无状态的, 每次需要动态产生, 需要类型信息
    //事件名字--控制器类型
    public static Dictionary<string, Type> CommandMap = new Dictionary<string, Type>();


    //注册上面的
    public static void RegisterModel(Model model)
    {
        Models[model.Name] = model;
    }

    public static void RegisterView(View view)
    {
        if (Views.ContainsKey(view.Name))
            Views.Remove(view.name);


        //完成注册
        view.RegisterEvent();
        Views[view.Name] = view;
    }

    public static void RegisterController(string eventName, Type type)
    {
        CommandMap[eventName] = type;
    }

    //获取
    public static T GetModel<T> () where T: Model
    {

        foreach(Model m in Models.Values)
        {
            if (m is T)
                return (T)m;
        }

        return null;
    }

    //获取View
    public static T GetView<T>() where T:View
    {
        foreach(View v in Views.Values)
        {
            if(v is T)
            {
                return v as T;
            }
        }

        return null;
    }


    //发送事件

    public static void SendEvent(string eventName, object data = null)
    {

        //控制器相应事件
        if(CommandMap.ContainsKey(eventName))
        {
            //通过事件名称找到控制器所对应的类型.
            Type type = CommandMap[eventName];

            //再将类型实例化为控制器
            Controller controller = Activator.CreateInstance(type) as Controller;

            controller.Execute(data);
        }
        //视图相应事件

        foreach(View v in Views.Values)
        {
            if(v.AttentionEvents.Contains(eventName))
            {
                v.HandleEvent(eventName, data);
            }
        }

    }
}