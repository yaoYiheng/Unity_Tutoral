using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
 
[CustomEditor(typeof(Test3))]
public class DemoCustomEditor : Editor {

    //public SerializedObject mObj;
    public SerializedProperty a;
    public SerializedProperty b;
    public SerializedProperty myClass;

    public void OnEnable()
    {
        //mObj = new SerializedObject(target);
        a = serializedObject.FindProperty("a");
        b  = serializedObject.FindProperty("b");
        myClass = serializedObject.FindProperty("myClass");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.PropertyField(a);
        EditorGUILayout.PropertyField(b);
        EditorGUILayout.PropertyField(myClass, true);
        serializedObject.ApplyModifiedProperties();
    }
}
