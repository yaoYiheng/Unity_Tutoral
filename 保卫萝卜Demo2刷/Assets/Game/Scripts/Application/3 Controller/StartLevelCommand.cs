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
        Game.Instance.LoadScene(3);
    }
}
