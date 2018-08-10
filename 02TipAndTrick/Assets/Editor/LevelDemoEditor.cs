using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LevelDemo))]
public class LevelDemoEditor : Editor
{

    public override void OnInspectorGUI()
    {
        //重写的话会调用父类的方法. 可以删除掉
        //base.OnInspectorGUI();
        LevelDemo myDemo = (LevelDemo)target;
        //在检视视图中创建一个文本输入框
        myDemo.experience = EditorGUILayout.IntField("Experience", myDemo.experience);
        //添加一个label
        //访问Level的get方法, 并将其转成字符串.
        EditorGUILayout.LabelField("Level", myDemo.Level.ToString());

        EditorGUILayout.HelpBox("简单分割线\n以下是调用了DrawDefaultInspector()出现的", MessageType.Info);

        DrawDefaultInspector();
    }

}