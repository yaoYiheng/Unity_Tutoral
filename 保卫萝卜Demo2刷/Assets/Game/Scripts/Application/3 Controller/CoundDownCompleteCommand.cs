using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoundDownCompleteCommand : Controller
{
    public override void Excute(object data)
    {
        //倒计时结束


        //回合开始
        GameModel gameModel = GetModel<GameModel>();
        gameModel.IsPlaying = true;
        RoundModel roundModel = GetModel<RoundModel>();
        roundModel.StartRound();
    }
}
