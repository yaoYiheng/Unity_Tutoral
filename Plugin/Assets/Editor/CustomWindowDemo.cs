using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomWindowDemo : EditorWindow
{

    public string mySTring;
    private Color myColor = Color.red;
    private int myInt;
    private float myFloat;
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
        //所有的空间都是在这个方法中绘制的
        if(GUILayout.Button("关闭"))
        {
            Close();
        }
        Debug.Log("OnGUI被调用");

        //添加标签
        EditorGUILayout.LabelField("文本标签");
        //绘制文本输入框
        mySTring = EditorGUILayout.TextField(mySTring);

        //添加空行
        EditorGUILayout.Space();

        //可被选中的标签
        EditorGUILayout.SelectableLabel("输入密码");
        mySTring = EditorGUILayout.PasswordField(mySTring);

        //绘制颜色面板
        myColor = EditorGUILayout.ColorField(myColor);

        EditorGUILayout.LabelField("整型输入");
        myInt =  EditorGUILayout.IntField(myInt);
        EditorGUILayout.Space();
        EditorGUILayout.LabelField("浮点输入");
        myFloat = EditorGUILayout.FloatField(myFloat);
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