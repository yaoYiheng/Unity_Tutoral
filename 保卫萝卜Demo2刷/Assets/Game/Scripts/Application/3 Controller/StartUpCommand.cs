using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUpCommand : Controller
{
    //这个类需要将MVC框架注册到系统当中
    // 是第一次加载, 完成跳转场景的任务
    public override void Excute(object data)
    {
        // 注册数据
        RegisterModel(new GameModel());
        RegisterModel(new RoundModel());
        // 注册控制器
        RegisterController(Consts.E_StartLevel, typeof(StartLevelCommand));
        RegisterController(Consts.E_EnterScene, typeof(EnterSceneCommand));
        RegisterController(Consts.E_ExitScene, typeof(ExitSceneCommand));
        RegisterController(Consts.E_CountDownCompleted, typeof(CoundDownCompleteCommand));
        RegisterController(Consts.E_EndLevel, typeof(EndLevelCommand));
        RegisterController(Consts.E_RestartRound, typeof(RestartRoundCommand));
        RegisterController(Consts.E_UpgradeTower, typeof(UpgradeTowerCommand));
        RegisterController(Consts.E_SellTower, typeof(SellTowerCommand));


        //数据的初始化
        GameModel game = GetModel<GameModel>();
        game.Init();


        //场景的第一跳
        Game.Instance.LoadScene(1);
    }
}
