using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class EventManger : MonoBehaviour 
{

    /// <summary>
    /// 声明一个返回值为void且无参数的delegate, 
    /// 
    /// </summary>
    public delegate void OnClickAction();
    /// <summary>
    /// 声明一个静态的事件
    /// </summary>
    public static event OnClickAction onClick;

    private void OnGUI()
    {
        if(GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2, 200, 60), "Click"))
        {
            //需要进行判断.
            if(onClick != null)
            {
                onClick();
            }
        }
    }
}
