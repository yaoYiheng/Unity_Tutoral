using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[AddComponentMenu("ATest2")]
public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    [ContextMenu("Menu1")]
    public void Test1()
    {
        Debug.Log("Test1");
    }
}
