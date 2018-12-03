using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevelCommand : Controller
{
    public override void Execute(object data)
    {

        //在接收到开始游戏点击按钮发布的开始场景的事件之后
        StartLevelArgs args = new StartLevelArgs();

        GameModel gameModel = new GameModel();
        // Debug.Log("args.LevelIndex == " + args.LevelIndex);
        gameModel.StartLevel(args.LevelIndex);
        
        //当接受到进入关卡的事件后, 跳转到LevelScene

        Game.Instance.LoadScene(3);
    }
}
