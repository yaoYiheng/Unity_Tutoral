using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour {


    public float OffsetX = 10.0f;
    public float LoopTime = 1.0f;

	// Use this for initialization
	void Start () {
        iTween.MoveBy(this.gameObject, iTween.Hash(
            "x", OffsetX,
            "easeType", iTween.EaseType.linear,
            "loopType", iTween.LoopType.loop,
            "time", LoopTime
        ));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
