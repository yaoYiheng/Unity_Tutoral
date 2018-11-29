using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour 
{
    public float OffsetX = 2000.0f;
    public float Time = 5.0f;

    private void Start()
    {
        iTween.MoveBy(this.gameObject, iTween.Hash(
            "x", OffsetX,
            "easeType", iTween.EaseType.linear,
            "loopType", iTween.LoopType.loop,
            "time", Time
        ));
    }
}