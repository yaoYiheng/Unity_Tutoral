using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomWindowOneDemo : EditorWindow 
{

    public int index;
    public string[] strs;
    public int[] ints;


    private string myTag;
    private int myLayer;
    private Object myGO;


    private bool isSelected;
    [MenuItem("Menu/窗口一")]
    public static void ShowWindow()
    {
        GetWindow<CustomWindowOneDemo>();
    }


    private void OnEnable()
    {
        strs = new string[]
        {
            "hello",
            "hello, One",
            "hello, Two",
            "hello, Three"
        };
        ints = new int[]
        {
            1, 2, 3, 4
        };
    }
    private void OnGUI()
    {
        index = EditorGUILayout.Popup(index, strs);
        index = EditorGUILayout.IntPopup(index, strs, ints);

        EditorGUILayout.Space();

        //单字选择
        isSelected = EditorGUILayout.Toggle("是否折叠", isSelected);

        if(isSelected = EditorGUILayout.Foldout(isSelected, "折叠"))
        {
            //在折叠的外围包裹一层, 需要与结尾的代码相互配合
            EditorGUILayout.BeginVertical(GUI.skin.box);
            EditorGUI.indentLevel++;

            //标签选择器
            EditorGUILayout.LabelField("标签");
            myTag = EditorGUILayout.TagField(myTag);
            EditorGUILayout.Space();

            //层级选择器
            EditorGUILayout.LabelField("层级");
            myLayer = EditorGUILayout.LayerField(myLayer);
            EditorGUILayout.Space();

            //对象选择器
            EditorGUILayout.LabelField("对象选择");
            myGO = EditorGUILayout.ObjectField(myGO, typeof(Transform));
            EditorGUILayout.Space();

            EditorGUI.indentLevel--;
            EditorGUILayout.EndVertical();
        }


    }
}