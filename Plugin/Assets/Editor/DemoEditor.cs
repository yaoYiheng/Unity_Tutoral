using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DemoEditor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    [MenuItem("Menu/Test1 _W")]
    public static void Test()
    {
        Debug.Log("Test");

    }
 
    [ContextMenu("Menu")]
    public void Test1()
    {
        Debug.Log("Test1");
    }
}
