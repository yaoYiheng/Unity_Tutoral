using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public abstract class ApplicationBase<T> : Singleton<T> where T:MonoBehaviour
{
    protected void RegisterController(string eventName, Type controllerType)
    {
        MVC.RegisterController(eventName, controllerType);
    }

}
