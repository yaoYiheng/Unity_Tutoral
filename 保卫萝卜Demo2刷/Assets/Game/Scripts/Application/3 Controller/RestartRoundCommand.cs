using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartRoundCommand : Controller
{
    public override void Excute(object data)
    {
        RoundModel roundModel = GetModel<RoundModel>();
        roundModel.RestartRound();
    }
}
