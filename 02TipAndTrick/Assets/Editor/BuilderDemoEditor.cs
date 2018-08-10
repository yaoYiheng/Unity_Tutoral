using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ObjectBuilderDemo))]
public class BuilderDemoEditor : Editor {


    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        //在该方法中, 有一个指向需要自定义的脚本的引用target
        //通过该引用, 可以访问到那个脚本中的属性与方法
        ObjectBuilderDemo builderDemo = (ObjectBuilderDemo)target;
        if (GUILayout.Button("添加新物体"))
        {
            //调用脚本引用的对象的方法
            builderDemo.Build();
        }

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
