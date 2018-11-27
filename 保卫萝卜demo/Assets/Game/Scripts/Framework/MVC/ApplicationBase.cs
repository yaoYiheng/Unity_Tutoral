using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public abstract class ApplicationBase<T> : Singleton<T> where T:MonoBehaviour
{
    //注册    
    protected void RegisterController(string eventName, Type controllerType)
    {
        MVC.RegisterController(eventName, controllerType);
    }

    //执行, 向系统发送一个启动消息.
    protected void SendEvent(string eventName)
    {
        MVC.SendEvent(eventName);
    }

}
