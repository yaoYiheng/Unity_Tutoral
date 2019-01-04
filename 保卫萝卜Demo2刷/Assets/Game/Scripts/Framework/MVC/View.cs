using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class View: MonoBehaviour
{
	public List<string> AttentionEventList = new List<string>();
	public abstract string Name {get;}

	//子类可以重写的, 将关心的事件添加到关心事件列表当中.
	public virtual void AddEventToList(){}

	public abstract void HandleEvent(string eventName, object data = null);


	
}