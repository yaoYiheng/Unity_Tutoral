using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomWindowDemo : EditorWindow
{

    [MenuItem("菜单/窗口")]
    public static void ShowWindow()
    {
        CreateInstance<CustomWindowDemo>().Show();

    }

    [MenuItem("菜单/窗一")]
    public static void ShowWindowOne()
    {
        //CreateInstance<CustomWindowDemo>().Show();
        CreateInstance<CustomWindowDemo>().ShowUtility();
    }

    [MenuItem("菜单/窗二")]
    public static void ShowWindowTwo()
    {
        //单利模式下的窗口, 不会多开. 
        EditorWindow.GetWindow<CustomWindowDemo>().Show();
        //CreateInstance<CustomWindowDemo>().ShowPopup();
    }
    [MenuItem("菜单/窗三")]
    public static void ShowWindowThree()
    {
        //点击窗口之外的区域, 窗口消失.
        CreateInstance<CustomWindowDemo>().ShowAuxWindow();
    }

    public void OnGUI()
    {
        if(GUILayout.Button("关闭"))
        {
            Close();
        }
        Debug.Log("OnGUI被调用");
    }

    public void OnEnable()
    {
        Debug.Log("OnEnable被调用");
    }
    private void OnSelectionChange()
    {
        Debug.Log("OnSelectionChange被调用");
        //返回被选中的游戏对象的数组
        for (int i = 0; i < Selection.gameObjects.Length; i++)
        {
            Debug.Log("选择了一个游戏对象: " + Selection.gameObjects[i].name);
        }
        //返回被选中的任何对象的数组
        for (int i = 0; i < Selection.objects.Length; i++)
        {
            Debug.Log("选择了一个对象: " + Selection.objects[i].name);
        }

    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy被调用");
    }
}