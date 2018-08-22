using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Test3 : MonoBehaviour {
    public MyEnum myEnum;
    public int a = 10;
    public float b = 10f;
    public MyClass myClass;
    public Color myColor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

[Serializable]
public class MyClass
{
    public string name;
    public float heigh;
}
public enum MyEnum
{
    None,
    IntVaule,
    FloatValue,
    ClassValue,
    ColorValue
}