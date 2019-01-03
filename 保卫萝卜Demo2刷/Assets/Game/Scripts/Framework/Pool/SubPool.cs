using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubPool 
{
	GameObject m_ObejctPrefab;
	List<GameObject> m_Objects = new List<GameObject>();


	//通过该名称来获取相应的对象
	public string Name
	{
		get{return m_ObejctPrefab.name;}
	}
	//构造函数.
	 public SubPool(GameObject go)
	 {
		 this.m_ObejctPrefab = go;
	 }

	//从池子中取出对象
	public GameObject OnSpawn(GameObject goPrefab)
	{
		GameObject go = null;

		//先对传入的对象进行查找, 是否存在于列表当中
		foreach (GameObject item in m_Objects)
		{
			if(m_Objects.Contains(item))
			{
				go = item;

				break;
			}
		}
		//没有找到的话就创建新的
		if(go == null)
		{
			go = GameObject.Instantiate<GameObject>(goPrefab);
			// 并将重新创建的游戏对象添加到列表当中
			m_Objects.Add(go);

		}
		// 这个语句应该放在if外, 是因为有可能传入的对象存在池子当中
		go.SetActive(true);
		//在返回前发送消息已备初始化
		go.SendMessage("OnSpawn", SendMessageOptions.DontRequireReceiver);
		return go;
	}

	//向池子中放入回收对象
	public void UnSpawn(GameObject go)
	{
		if(m_Objects.Contains(go))
		{
			go.SetActive(false);
			go.SendMessage("UnSpawn", SendMessageOptions.DontRequireReceiver);
		}
	}
	//回收所有

	public void UnSpawnAll()
	{
		foreach (GameObject item in m_Objects)
		{
			// 对处于可用状态下 的对象做回收处理.
			if(item.activeSelf)
				UnSpawn(item);
		}
	}
}