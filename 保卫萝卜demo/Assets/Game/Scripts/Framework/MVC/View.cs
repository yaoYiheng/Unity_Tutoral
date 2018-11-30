using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 在Unity中 都会挂在到游戏对象上, 所以需要继承自Mono
/// </summary>
public abstract class View : MonoBehaviour 
{
    //视图标识
    public abstract string Name { get; }

    //关心的事件列表
    [HideInInspector]
    public List<string> AttentionEvents = new List<string>();

    //虚函数, 提供给子类, 待需要将关心的事件添加到列表中的时候调用.
    public virtual void RegisterEvent(){}

    //用来处理事件的函数
    public abstract void  HandleEvent(string eventName, object data);

    //获取模型
    public Model GetModel<T>() where T: Model
    {
        return MVC.GetModel<T>();
    }


    //向控制发送消息
    public void SendEvent(string eventName, object data = null)
    {
        MVC.SendEvent(eventName, data);
    }
}
