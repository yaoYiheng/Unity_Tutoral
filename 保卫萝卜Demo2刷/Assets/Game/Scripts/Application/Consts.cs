using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Consts
{
    public static string LevelPath = Application.streamingAssetsPath + @"/Levels";
    public static string MapPath = Application.streamingAssetsPath + @"/Maps/";
    public static string CardPath = Application.streamingAssetsPath + @"/Cards/";



    public const float CloseDistance = 0.1f;
    public const float CloseRange = 0.7f;

    //数据
    public const string M_GameModel = "M_GameModel";
    public const string M_RoundModel = "M_RoundModel";
    public const string GameProgress = "GameProgress";

    //视图
    public const string V_Start = "V_Start";
    public const string V_Select = "V_Select";
    public const string V_Board = "V_Board";
    public const string V_CountDown = "V_CountDown";
    public const string V_Spawner = "V_Spawner";
    public const string V_Win = "V_Win";
    public const string V_Lost = "V_Lost";
    public const string V_TowerPopup = "V_TowerPopup";
    public const string V_Menu = "V_Menu";
    public const string V_Completed = "V_Completed";

    //控制器

    public const string E_StartUp = "E_StartUp"; //None Args

    public const string E_EnterScene = "E_EnterScene"; //SceneIndexArgs
    public const string E_ExitScene = "E_ExitScene";   //SceneIndexArgs

    public const string E_CountDownCompleted = "E_CountDownCompleted";

    public const string E_StartRound = "E_StartRound";
    public const string E_SpawnMonster = "E_SpawnMonster";
    public const string E_SpawnTower = "E_SpawnTower"; //SpawnTowerArgs

    //开始关卡
    public const string E_StartLevel = "E_StartLevel";
    public const string E_EndLevel = "E_EndLevel";

    //怪物死亡
    public const string E_MonsterDead = "E_MonsterDead";
    //创建炮塔
    public const string E_CreatPanel = "E_CreatPanel";

    //显示创建炮塔页面
    public const string E_ShowCreatPanel = "E_ShowCreatPanel";
    //显示升级炮塔 页面
    public const string E_ShowUpgradePanel = "E_ShowUpgradePanel";

    //隐藏所有页面
    public const string E_HideAllPanels = "E_HideAllPanels";

    public const string E_Suspend = "E_Suspend";
    public const string E_MenuShow = "E_MenuShow";
    public const string E_RestartRound = "E_RestartRound";

    //升级炮塔事件
    public const string E_UpgradeTower = "E_UpgradeTower"; //UpgradeToweArgs
    public const string E_SellTower = "E_SellTower"; //SellTowerArgs
}

public enum GameSpeed
{
    SpeedOne,
    SpeedTwo
}

public enum MonsterType
{
    monsterOne,
    monsterTwo,
    monsterThree,
    monsterFour,
    mouserFive,
    monsterSix,
    monsterSeven
}