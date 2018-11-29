using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bird : MonoBehaviour 
{
    //控制鸟上下移动.

    //一次循环所需时间
    public float Time = 1.0f;
    //Y轴上的浮动
    public float OffsetY = 10.0f;


    private void Start()
    {
        iTween.MoveBy(this.gameObject, iTween.Hash(
            "y", OffsetY,
            "easeType", iTween.EaseType.easeInOutSine,
            "loopType", iTween.LoopType.pingPong,
            "time", Time));

    }
}