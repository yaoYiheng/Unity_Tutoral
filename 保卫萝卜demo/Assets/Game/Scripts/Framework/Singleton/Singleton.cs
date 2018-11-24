using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T m_instance = null;

    //只读公共 返回单例
    public static T Instance
    {
        get { return m_instance; }
    }

    //为了能让子类继承加上 virtual关键字.
    protected virtual void Awake()
    {
        m_instance = this as T;
    }
}
