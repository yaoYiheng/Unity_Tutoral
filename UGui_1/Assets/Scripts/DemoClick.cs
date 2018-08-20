using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        Debug.Log("点击" + transform.name);
    }
}
