using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Model 
{
	public abstract string Name{get;}

	protected virtual void SendEvent(string name, object data = null)
	{
		MVC.SendEvent(name, data);
	}
}