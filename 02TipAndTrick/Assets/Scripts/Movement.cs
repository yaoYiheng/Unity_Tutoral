using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
    public float turnSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        MovementDemo();
	}

    private void MovementDemo ()
    {
        float turnMove = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(Vector3.forward * move);
        transform.Rotate(Vector3.up * turnMove);
    }
}
