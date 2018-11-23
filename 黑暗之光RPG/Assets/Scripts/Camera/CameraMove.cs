using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {


    public int speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveCamera();
	}

    private void MoveCamera()
    {

        if(transform.position.z < 102)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);    
        }

    }
}
