using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubPool : MonoBehaviour 
{
    GameObject ObjPrefab;
    List<GameObject> GameObjectList = new List<GameObject>();

    // 该池子的名字, 因为传入的prefab都是一致的, 所以就使用预设的名字
    public string Name
    {
        get { return ObjPrefab.name; }
    }

    //构造方法
    public SubPool(GameObject prefab)
    {
        this.ObjPrefab = prefab;
    }

    //当需要创建一个新的对象的时候 
    //从池子中获取
    public GameObject Spawn()
    {
        GameObject item = null;

        //列表里装载的都是待用的游戏对象,
        //处于 如果想要获取一个可以被使用的对象
        //其实获取的是一个gameObject.SetActive(false)的对象
        foreach(GameObject obj in GameObjectList)
        {
            if(!obj.activeSelf)
            {
                item = obj;
                break;
            }
        }

        if(item == null)
        {
            //根据传递的prefab创建新的游戏对象, 并添加到列表中
            item = Instantiate<GameObject>(ObjPrefab);

            GameObjectList.Add(item);
        }

        //如果能够从池子里获取到, 则需要将其设置为可用
        item.SetActive(true);

        //发送消息
        item.SendMessage("OnSpawn", SendMessageOptions.DontRequireReceiver);

        return item;
    }


    //回收对象
    public void UnSpawn(GameObject obj)
    {
        //判断是否包含该对象
        if(Contains(obj))
        {
            //向对象发送信息, 告知对象即将被回收
            obj.SendMessage("UnSpawn", SendMessageOptions.DontRequireReceiver);
            obj.SetActive(false);

        }

    }

    public void UnSpawnAll()
    {
        //将列表中的正在使用的元素都都回收
        foreach(GameObject item in GameObjectList)
        {
            //
            if(item.activeSelf)
            {
                UnSpawn(item);
            }


        }
    }


    public bool Contains(GameObject obj)
    {


        return GameObjectList.Contains(obj);
    }
    //回收所有对象
}
