using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour 
{
    //将路径设置为常量
    public const string UIPath = "UI_Prefab/";
    //静态的类来保留画布?
    public static GameObject m_UICanvas;

    public static List<MonoBehaviour>m_UIList = new List<MonoBehaviour>();
    private static void InitData()
    {
        m_UICanvas = GameObject.Find("Canvas");
    }

    public static T EnterUI<T>() where T : UILayer 
    {
        if(m_UICanvas == null)
        {
            InitData();
        }
        //初始化一个从资源文件目录加载的
        //并由字符串拼接 + 转换类名的游戏对象.
        GameObject ui_Main = Instantiate(Resources.Load(UIPath + typeof(T).ToString())) as GameObject;

        ui_Main.transform.SetParent(m_UICanvas.transform);

        //初始化局部坐标相关
        ui_Main.transform.localScale = Vector3.one;
        ui_Main.transform.localPosition = Vector3.zero;
        ui_Main.transform.localRotation = Quaternion.identity;


        RectTransform transform = ui_Main.GetComponent<RectTransform>();

        //初始化偏移距离
        transform.offsetMin = Vector2.zero;
        transform.offsetMax = Vector2.zero;

        //初始化锚点
        transform.anchorMin = Vector2.zero;
        transform.anchorMax = Vector2.one;


        T t = ui_Main.AddComponent<T>();
        t.__init_node(t.transform);
        t.OnNodeLoad();
        m_UIList.Add(t);

        return t;
    }

    public static void ExitUI(MonoBehaviour mono)
    {
        //退出的时候删除最后一个

        m_UIList.Remove(mono);
        Destroy(mono.gameObject);  
    }
    public static void ExitAllUI ()
    {
        for (int i = 0; i < m_UIList.Count; i++)
        {
            Destroy(m_UIList[i].gameObject);
        }
        m_UIList.Clear();
    }
}
