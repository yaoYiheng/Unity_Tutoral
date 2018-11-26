using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 所有数据层的基类, 不需要被实例化, 被定义为抽象类
/// </summary>
public abstract class Model 
{
     /// 模型需要被存储到某个地方, 提供一个名字以查找

    public abstract string Name { get; }

    protected void SendEvent(string eventName, object data = null)
    {
        MVC.SendEvent(eventName, data);
    }
}
