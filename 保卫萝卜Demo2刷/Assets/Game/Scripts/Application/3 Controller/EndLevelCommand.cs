using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelCommand : Controller
{
    public override void Excute(object data)
    {

        //接受游戏的参数, 根据是否赢来显示不同的页面
        EndLevelArgs endLevelArgs = data as EndLevelArgs;
        GameModel gameModel = GetModel<GameModel>();
        RoundModel roundModel = GetModel<RoundModel>();
        gameModel.EndLevel(endLevelArgs.IsWin);
        roundModel.PauseRound();

        if (endLevelArgs.IsWin)
        {
            //显示UIWin画面
            GetView<UIWin>().Show();
        
        }
        else
        {
            GetView<UILost>().Show();
        }
    }
}
