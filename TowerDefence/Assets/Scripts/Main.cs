using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour 
{
    /*
     * 1. Prefab加载
     * 2. 实例化Prefab
     * 3. 初始化
     * 4. 显示UI
     * ..
     * 关闭 

    */

    private void Start()
    {
   /*
                //从资源中找到刚刚制作好的UI_Main文件
                GameObject resource = Resources.Load<GameObject>("UI_Prefab/UI_Main");

                ////实例化该文件
                GameObject ui_Main = Instantiate(resource);
                //GameObject ui_Main = Instantiate(Resources.Load("Prefabs/UI_Prefab/UI_Main", typeof(GameObject))) as GameObject;

                //将实例化的UI添加到画布上. 需要先获取到画布
                GameObject ui_Canvas = GameObject.Find("Canvas");
                //通过setParent设置其父组件
                ui_Main.transform.SetParent(ui_Canvas.transform);

                //添加到父控件后, 需要将其局部坐标等初始化
                ui_Main.transform.localPosition = Vector3.zero;
                ui_Main.transform.localScale = Vector3.one;
                ui_Main.transform.localRotation = Quaternion.identity;

                //设置其相关的锚点为0.
                RectTransform rect = ui_Main.GetComponent<RectTransform>();
                rect.offsetMin = Vector2.zero;
                rect.offsetMax = Vector2.zero;

                //将UI_Main的脚本添加到UI_Main这个游戏对象上
                ui_Main.AddComponent<UI_Main>();
        */
        UIManager.EnterUI<UI_Main>();
    }
}
