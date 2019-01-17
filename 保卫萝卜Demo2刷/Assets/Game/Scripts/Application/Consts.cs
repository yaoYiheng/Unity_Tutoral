using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Consts
{
    public static string LevelPath = Application.streamingAssetsPath + @"/Levels";
    public static string MapPath = Application.streamingAssetsPath + @"/Maps/";
    public static string CardPath = Application.streamingAssetsPath + @"/Cards/";

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

    //控制器

    public const string E_StartUp = "E_StartUp"; //None Args

    public const string E_EnterScene = "E_EnterScene"; //SceneIndexArgs
    public const string E_ExitScene = "E_ExitScene";   //SceneIndexArgs

    public const string E_CountDownCompleted = "E_CountDownCompleted";

    public const string E_StartRound = "E_StartRound";
    public const string E_SpawnMonster = "E_SpawnMonster";

    //开始关卡
    public const string E_StartLevel = "E_StartLevel";
    public const string E_EndLevel = "E_EndLevel";

    //怪物死亡
    public const string E_MonsterDead = "E_MonsterDead";
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