using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownCompleteCommand : Controller
{
    public override void Execute(object data)
    {
        Debug.Log("倒计时结束");
        //倒计时结束后.
        RoundModel model = GetModel<RoundModel>();
        model.StartRound();
    }
}