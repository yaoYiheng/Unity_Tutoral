using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : Singleton <ObjectPool>
{
    public string ResoursePath = "";

    private Dictionary<string, SubPool> m_ObjectPool = new Dictionary<string, SubPool>();


    //取对象

    public GameObject OnSpawn(string prefab)
    {
        if (!m_ObjectPool.ContainsKey(prefab))
            Register(prefab);
        //如果不存在传入的prefab, 就在将其创建完之后返回创建出来的即可
        return m_ObjectPool[prefab].Spawn();
    }

    //回收对象

    public void UnSpawn(GameObject go)
    {

        SubPool subPool = null;
        //判断该对象属于哪个池子
        foreach(SubPool pool in m_ObjectPool.Values)
        {
            if (pool.Contains(go))
            {
                subPool = pool;

                break;
            }
        }

        subPool.UnSpawn(go);
    }
    

    //回收所有对象
    public void UnSpawnAll()
    {
        foreach(SubPool pool in m_ObjectPool.Values)
        {
            pool.UnSpawnAll();
        }
    }
    void Register(string prefab)
    {
        string path = "";

        if(string.IsNullOrEmpty(ResoursePath))
        {
            path = prefab;
        }
        else
        {
            path = ResoursePath + "/" + prefab;
        }

        //根据路径加载预制
        GameObject item = Resources.Load<GameObject>(path);

        SubPool pool = new SubPool(item);

        //添加至字典
        m_ObjectPool.Add(item.name, pool);

    }
}
