using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressAny : MonoBehaviour {


    private GameObject Buttons;
	// Use this for initialization
	void Start () 
    {
        Buttons = transform.parent.Find("Buttons").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        ShowNewButton();
	}

    void ShowNewButton()
    {
        if(Input.anyKeyDown)
        {
            Buttons.SetActive(true);
            this.gameObject.SetActive(false);
            
        }
    }
}
