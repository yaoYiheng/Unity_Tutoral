using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
 
[CustomEditor(typeof(Test3))]
public class DemoCustomEditor : Editor {

    //public SerializedObject mObj;
    public SerializedProperty mEnum;
    public SerializedProperty a;
    public SerializedProperty b;
    public SerializedProperty myClass;
    public SerializedProperty myColor;
    public void OnEnable()
    {
        mEnum = serializedObject.FindProperty("myEnum");
        a = serializedObject.FindProperty("a");
        b  = serializedObject.FindProperty("b");
        myClass = serializedObject.FindProperty("myClass");
        myColor = serializedObject.FindProperty("myColor");
    }

    public override void OnInspectorGUI()
    {
        //更新
        serializedObject.Update();

        //绘制出枚举
        EditorGUILayout.PropertyField(mEnum);

        //根据枚举的不同值, 来决定绘制不同的界面
        switch(mEnum.enumValueIndex)
        {
            case 1:
                EditorGUILayout.PropertyField(a);
                break;
            case 2:
                EditorGUILayout.PropertyField(b);
                break;
            case 3:
                EditorGUILayout.PropertyField(myClass, true);
                break;
            case 4:
                EditorGUILayout.PropertyField(myColor);
                break;
        }


        //应用
        serializedObject.ApplyModifiedProperties();
    }
}
