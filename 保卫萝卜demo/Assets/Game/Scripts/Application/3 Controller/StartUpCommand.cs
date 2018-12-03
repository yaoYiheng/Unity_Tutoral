using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUpCommand : Controller
{
    public override void Execute(object data)
    {
        //注册模型(Model)
        RegisterModel(new GameModel());
        RegisterModel(new RoundModel());


        //注册命令(Controller)


        RegisterController(Const.E_EnterScene, typeof(EnterSceneCommand));
        RegisterController(Const.E_ExitScene, typeof(ExitSceneCommand));

        RegisterController(Const.E_StartLevel, typeof(StartLevelCommand));
        RegisterController(Const.E_EndLevel, typeof(EndLevelCommand));

        RegisterController(Const.E_CountDownComplete, typeof(CountDownCompleteCommand));
        //进入开始界面

        //对模型数据进行初始化
        //获取到已经添加到内存中Model, 将其初始化.!!!
        GameModel gameModel = GetModel<GameModel>();

        // Debug.Log( "Initialize之前" + MVC.GetModel<GameModel>().LevelCount);
        gameModel.Initialize();




        
        Game.Instance.LoadScene(1);
    }
} 