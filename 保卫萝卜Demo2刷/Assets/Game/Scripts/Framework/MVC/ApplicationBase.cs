using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public abstract class ApplicationBase<T> : Singleton<T> where T: MonoBehaviour
{

	protected void RegisterController(string name, Type controllerType)
	{
		MVC.RegisterController(name, controllerType);
	}

    protected void SendEvent(string eventName, object data = null)
	{
		MVC.SendEvent(eventName, data);
	}

}
