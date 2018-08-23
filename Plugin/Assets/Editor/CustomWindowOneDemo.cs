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
        EditorGUILayout.LabelField("标签");
        myTag = EditorGUILayout.TagField(myTag);
        EditorGUILayout.Space();

        EditorGUILayout.LabelField("层级");
        myLayer = EditorGUILayout.LayerField(myLayer);
        EditorGUILayout.Space();

        EditorGUILayout.LabelField("对象选择");
        myGO = EditorGUILayout.ObjectField(myGO, typeof(Transform));
        EditorGUILayout.Space();

    }
}