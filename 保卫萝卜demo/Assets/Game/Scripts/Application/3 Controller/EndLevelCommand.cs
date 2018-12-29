using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelCommand : Controller
{
    public override void Execute(object data)
    {
        EndLevelArgs end = data as EndLevelArgs;

        //保存游戏状态
        GameModel game = GetModel<GameModel>();
        RoundModel round = GetModel<RoundModel>();
        game.EndLevel(end.IsSuccessed);
        round.EndRound();

        if(end.IsSuccessed)
        {
            //当胜利的时候跳转到UIWin场景
            GetView<UIWin>().Show();
        }
        else
        {
            //失败跳转UILost
            GetView<UILost>().Show();
            

        }
    }
}
