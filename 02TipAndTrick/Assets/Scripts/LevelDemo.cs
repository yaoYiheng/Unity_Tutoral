using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDemo : MonoBehaviour {

	// Use this for initialization

    public int experience;


    public int Level
    {
        get { return experience / 500; }
    }


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
