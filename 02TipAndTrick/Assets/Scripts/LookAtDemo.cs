using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtDemo : MonoBehaviour {

    public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //transform.LookAt(target);


        Vector3 relativePos = target.position - transform.position;
        //通过传入一个Vetor3, 返回一个z轴朝向view, y轴朝向up的的旋转.
        //可以实现一个物体始终朝向target的效果
        transform.rotation = Quaternion.LookRotation(relativePos);
	}
}
