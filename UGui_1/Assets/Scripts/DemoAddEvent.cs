using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DemoAddEvent : MonoBehaviour {

	// Use this for initialization
	void Start () {
        EventManager.addEventListner(gameObject, EventTriggerType.PointerClick, OnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick(BaseEventData data)
    {
        Debug.Log(data.ToString());
    }
}
