using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {


    MeshRenderer meshRenderer;
	// Use this for initialization
	void Start () {
        meshRenderer = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.R))
        {
            meshRenderer.material.color = Color.red;
        }
        else if(Input.GetKeyDown(KeyCode.G))
        {
            meshRenderer.material.color = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            meshRenderer.material.color = Color.blue;
        }
	}
}
