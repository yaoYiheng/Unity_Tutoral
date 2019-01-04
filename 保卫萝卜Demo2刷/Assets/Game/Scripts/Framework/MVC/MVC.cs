using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MVC 
{

	static Dictionary<string, Model> Models = new Dictionary<string, Model>();
	static Dictionary<string, View> Views = new Dictionary<string, View>();
	static Dictionary<string, Type> Controllers = new Dictionary<string, Type>();

	// 将传入的MVC各个组件注册到内存当中.
	public static void RegisterModel(Model model)
	{	
		Models[model.Name] = model;
	}
	public static void RegisterView(View view)
	{
		//放置重复注册
		if (Views.ContainsKey(view.Name))
		{
			Views.Remove(view.Name);
		}
		// 调用将事件添加到关心列表的方法
		view.AddEventToList();

		//注册
		Views[view.Name] = view;
	}
	//注册控制器
	public static void RegisterController(string name, Type controllerType)
	{
		Controllers[name] = controllerType;
	}
	
	//获取数据模型
	public static T GetModel<T>() where T: Model
	{
		foreach (Model item in Models.Values)
		{
			if (item is T)
			{
				return item as T;
			}
		}
		return null;
	}

	public static T GetView<T>() where T: View
	{
		foreach (View item in Views.Values)
		{


			if(item is T)	return item as T;
		}
		return null;
	}
	//对两个可以发送事件的模块整合. 这个逻辑可以不用多次写.
	public static void SendEvent(string name, object data = null)
	{
		//先是 控制器对事件进行相应
		// 首先判断控制器字典中, 是否含有传入的控制器
		if (Controllers.ContainsKey(name))
		{
			//获取到key所对应的控制器的类型
			Type t = Controllers[name];
			
			//将该类型的控制器实例化出来
			Controller controller = Activator.CreateInstance(t) as Controller;
			
			//再由控制器对事件进行出来
			controller.Excute(data);
		}

		//接下来就是试图处理事件
		foreach (View item in Views.Values)
		{	
			if (item.AttentionEventList.Contains(name))
			{
				//对该事件进行处理
				item.HandleEvent(name, data);
			}
		}
	}
}
