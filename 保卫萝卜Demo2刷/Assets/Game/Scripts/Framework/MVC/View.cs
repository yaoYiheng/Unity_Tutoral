using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class View: MonoBehaviour
{
    [HideInInspector]
	public List<string> AttentionEventList = new List<string>();
	public abstract string Name {get;}

	//子类可以重写的, 将关心的事件添加到关心事件列表当中.
	public virtual void AddEventToList(){}

	public abstract void HandleEvent(string eventName, object data = null);

    //获取到模型数据
    protected T GetModel<T>() where T: Model
    {
        return MVC.GetModel<T>() as T;
    }

    protected void SendEvent(string eventName, object data = null)
    {
        MVC.SendEvent(eventName, data);
    }
	
}