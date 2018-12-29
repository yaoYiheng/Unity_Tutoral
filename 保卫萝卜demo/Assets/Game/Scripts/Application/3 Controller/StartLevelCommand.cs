using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevelCommand : Controller
{
    public override void Execute(object data)
    {

        //在接收到开始游戏点击按钮发布的开始场景的事件之后
        StartLevelArgs args = data as StartLevelArgs;

        GameModel gameModel = GetModel<GameModel>();

        gameModel.StartLevel(args.LevelIndex);
        

        //从GameModel中获取到当前正在玩的level, 因为RoundModel需要用到, 所以需要传入到
        //RoundModel当中
        RoundModel model = GetModel<RoundModel>();

        model.LoadRoundFromLevel(gameModel.PlayingLevel);


        //当接受到进入关卡的事件后, 跳转到LevelScene

        Game.Instance.LoadScene(3);
    }
}
