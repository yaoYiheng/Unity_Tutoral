using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevelCommand : Controller
{
    public override void Excute(object data)
    {
        StarLevelArgs args = data as StarLevelArgs;

        GameModel game = GetModel<GameModel>();
        game.StartLevel(args.LevelCardIndex);

        //初始化金币
        game.Gold = game.AllLevels[game.CurrentPlayingIndex].InitGold;

        //开始游戏回合
        RoundModel roundModel = GetModel<RoundModel>();

        //从游戏数据中, 加载当前关卡
        roundModel.LoadRounds(game.CurrerntLevel);
        Game.Instance.LoadScene(3);
    }
}
