using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDemo : MonoBehaviour {

    public float speed;
    public float turnSpeed;
	// Use this for initialization
	void Start () {
		
	}

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {

            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);
        }
    }
}
