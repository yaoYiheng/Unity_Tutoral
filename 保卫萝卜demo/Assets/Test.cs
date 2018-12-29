using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	SpriteRenderer rendererd;
	// Use this for initialization

	void Awake()
	{
		rendererd = GetComponent<SpriteRenderer>();
	}
	void Start () {

		rendererd.sprite = Resources.Load<Sprite>("Res/Roles/Bottle/Bottle00");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
