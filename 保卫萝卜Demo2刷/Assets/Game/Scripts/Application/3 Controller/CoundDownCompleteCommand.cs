using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoundDownCompleteCommand : Controller
{
    public override void Excute(object data)
    {
        //倒计时结束
        Debug.Log("开始出怪");

        //回合开始
        RoundModel roundModel = GetModel<RoundModel>();
        roundModel.StartRound();
    }
}
