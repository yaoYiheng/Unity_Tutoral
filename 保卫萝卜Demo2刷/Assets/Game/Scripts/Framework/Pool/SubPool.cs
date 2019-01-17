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

    //    GameObject ObjPrefab;
    //    List<GameObject> GameObjectList = new List<GameObject>();

    //    // 该池子的名字, 因为传入的prefab都是一致的, 所以就使用预设的名字
    //    public string Name
    //    {
    //        get { return ObjPrefab.name; }
    //    }
	//构造函数.
	 public SubPool(GameObject go)
	 {
		 this.m_ObejctPrefab = go;
	 }

    //    //构造方法
    //    public SubPool(GameObject prefab)
    //    {
    //        this.ObjPrefab = prefab;
    //    }

	//从池子中取出对象
	public GameObject Spawn()
	{
		GameObject go = null;

		//先对传入的对象进行查找, 是否存在于列表当中
		foreach (GameObject item in m_Objects)
		{
            //在子对象池中查找, 是否有处于未激活状态的游戏对象. 
            if(!item.activeSelf)
			{
				go = item;

				break;
			}
		}
		//没有找到的话就创建新的
		if(go == null)
		{
            go = GameObject.Instantiate<GameObject>(m_ObejctPrefab);
			// 并将重新创建的游戏对象添加到列表当中
			m_Objects.Add(go);

		}
		// 这个语句应该放在if外, 是因为有可能传入的对象存在池子当中
		go.SetActive(true);
		//在返回前发送消息已备初始化
		go.SendMessage("OnSpawn", SendMessageOptions.DontRequireReceiver);
		return go;
	}

    //    //当需要创建一个新的对象的时候 
    //    //从池子中获取
    //    public GameObject Spawn()
    //    {
    //        GameObject item = null;

    //        //列表里装载的都是待用的游戏对象,
    //        //处于 如果想要获取一个可以被使用的对象
    //        //其实获取的是一个gameObject.SetActive(false)的对象
    //        foreach (GameObject obj in GameObjectList)
    //        {
    //            if (!obj.activeSelf)
    //            {
    //                item = obj;
    //                break;
    //            }
    //        }

    //        if (item == null)
    //        {
    //            //根据传递的prefab创建新的游戏对象, 并添加到列表中
    //            item = Instantiate<GameObject>(ObjPrefab);

    //            GameObjectList.Add(item);
    //        }

    //        //如果能够从池子里获取到, 则需要将其设置为可用
    //        item.SetActive(true);

    //        //发送消息
    //        item.SendMessage("OnSpawn", SendMessageOptions.DontRequireReceiver);

    //        return item;
    //    }

	//向池子中放入回收对象
	public void UnSpawn(GameObject go)
	{
		if(m_Objects.Contains(go))
		{
			go.SendMessage("UnSpawn", SendMessageOptions.DontRequireReceiver);
			go.SetActive(false);
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

    public bool Contains(GameObject go)
    {
        return m_Objects.Contains(go);
    }
}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class SubPool : MonoBehaviour
//{
//    GameObject ObjPrefab;
//    List<GameObject> GameObjectList = new List<GameObject>();

//    // 该池子的名字, 因为传入的prefab都是一致的, 所以就使用预设的名字
//    public string Name
//    {
//        get { return ObjPrefab.name; }
//    }

//    //构造方法
//    public SubPool(GameObject prefab)
//    {
//        this.ObjPrefab = prefab;
//    }

//    //当需要创建一个新的对象的时候 
//    //从池子中获取
//    public GameObject Spawn()
//    {
//        GameObject item = null;

//        //列表里装载的都是待用的游戏对象,
//        //处于 如果想要获取一个可以被使用的对象
//        //其实获取的是一个gameObject.SetActive(false)的对象
//        foreach (GameObject obj in GameObjectList)
//        {
//            if (!obj.activeSelf)
//            {
//                item = obj;
//                break;
//            }
//        }

//        if (item == null)
//        {
//            //根据传递的prefab创建新的游戏对象, 并添加到列表中
//            item = Instantiate<GameObject>(ObjPrefab);

//            GameObjectList.Add(item);
//        }

//        //如果能够从池子里获取到, 则需要将其设置为可用
//        item.SetActive(true);

//        //发送消息
//        item.SendMessage("OnSpawn", SendMessageOptions.DontRequireReceiver);

//        return item;
//    }


//    //回收对象
//    public void UnSpawn(GameObject obj)
//    {
//        //判断是否包含该对象
//        if (Contains(obj))
//        {
//            //向对象发送信息, 告知对象即将被回收
//            obj.SendMessage("UnSpawn", SendMessageOptions.DontRequireReceiver);
//            obj.SetActive(false);

//        }

//    }

//    public void UnSpawnAll()
//    {
//        //将列表中的正在使用的元素都都回收
//        foreach (GameObject item in GameObjectList)
//        {
//            //
//            if (item.activeSelf)
//            {
//                UnSpawn(item);
//            }


//        }
//    }


//    public bool Contains(GameObject obj)
//    {


//        return GameObjectList.Contains(obj);
//    }
//    //回收所有对象
//}
