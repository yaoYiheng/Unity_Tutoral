using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBuilderDemo : MonoBehaviour {

    public GameObject obj;
    public Vector3 spawnPoint;

    public void Build()
    {
        Instantiate(obj, spawnPoint, Quaternion.identity);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
