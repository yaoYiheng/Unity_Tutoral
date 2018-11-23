using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {


    public float ScrollSpeed = 10.0f;
    public float turnSpeed = 10.0f;
    private Transform target;
    private Vector3 offset;
    private float defaultY;
    private float zoomDistance = 2.0f;
    private bool isRotate = false;

	// Use this for initialization
	void Start () {
        target = GameObject.FindWithTag(Tags.Player).transform;
        defaultY = transform.position.y;
        offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () 
    {
        Follow();
        Rotate();
        Zoom();
    }

	
    void Follow()
    {
        transform.position = target.position + offset;
    }

    private void Zoom()
    {
        float scrollValue = Input.GetAxis("Mouse ScrollWheel");

        float distance = offset.magnitude;

        distance = distance + scrollValue * ScrollSpeed;

        //限定
        distance = Mathf.Clamp(distance, 3, 12);



        offset = offset.normalized * distance;
    }
    private void Rotate()
    {
        Vector3 originalPos = transform.position;
        Quaternion originalRot = transform.rotation;

        ////如果当鼠标按下右键的时候, 则标记会旋转
        if (Input.GetMouseButtonDown(1))
        {
            isRotate = true;

        }
        if (Input.GetMouseButtonUp(1))
        {
            isRotate = false;
        }
        if (isRotate)
        {

            transform.RotateAround(target.position, target.up, Input.GetAxis("Mouse X") * turnSpeed);
            transform.RotateAround(target.position, target.right, -Input.GetAxis("Mouse Y") * turnSpeed);




            float tempX = transform.eulerAngles.x;



            if(tempX < 5 || tempX > 80)
            {
                //transform.rotation = Quaternion.Euler(10, transform.eulerAngles.y, transform.eulerAngles.z);

                transform.position = originalPos;
                transform.rotation = originalRot;
                    
            }
            transform.LookAt(target.position);
            offset = transform.position - target.position;

        }


    }

}
