using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {


    public float OffsetY = 10.0f;
    public float LoopTime = 1.0f;

	// Use this for initialization
	void Start () {
        iTween.MoveBy(this.gameObject, iTween.Hash(
            "y", OffsetY,
            "easeType", iTween.EaseType.easeInOutSine,
            "loopType", iTween.LoopType.pingPong,
            "time", LoopTime
        ));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
