﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDemo : MonoBehaviour {

    public float rotateSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(new Vector3(0, Time.deltaTime * rotateSpeed, 0), Space.World);
        transform.Rotate(Vector3.up, Time.deltaTime, Space.World);
	}
}
