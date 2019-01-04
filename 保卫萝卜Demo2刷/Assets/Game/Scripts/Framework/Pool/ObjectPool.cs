using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool: Singleton<ObjectPool>
{
	public string ResourcePath = "";

	Dictionary<string, SubPool> m_Pools = new Dictionary<string, SubPool>();


	public GameObject OnSpawn(string prefabName)
	{
		//对传入的预设名进行判断
		// 如果字典中并不含有传入的key. 则根据这个预设重新创建一个子池子
		if(!m_Pools.ContainsKey(prefabName))
			Register(prefabName);

		SubPool pool = m_Pools[prefabName];
		
		return pool.OnSpawn();
	}

	public void UnSpawn(GameObject go)
	{
		//先判断传入的游戏对象是否属于某个池子.
		 SubPool pool = null;

		 //遍历字典中所有的值
		 //在所有池子的集合中, 查找是否有包含传入的对象的池子.
		 foreach (SubPool item in m_Pools.Values)
		 {	
			if(item.Contains(go))
				pool = item; 

			break;	
		 }
		 pool.UnSpawn(go);
	}

	public void UnSpawnAll()
	{
		foreach(SubPool pool in m_Pools.Values)
		{
			pool.UnSpawnAll();
		}
	}

	void Register(string prefabName)
	{
		string path = "";
		if(string.IsNullOrEmpty(ResourcePath))
		{
			path = prefabName;
		}
		else
		{
			path = ResourcePath + "/" + prefabName;
		}

		//根据文件路径从资源中加载预设
		GameObject go = Resources.Load<GameObject>(path);


		SubPool pool = new SubPool(go);
		m_Pools.Add(pool.Name, pool);
	}
}