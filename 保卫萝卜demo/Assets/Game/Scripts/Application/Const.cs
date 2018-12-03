﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public static class Const 
{
    //目录
    public static readonly string LevelPath = Application.dataPath + "/Game/Res/Levels/";
    public static readonly string MapPath = Application.dataPath + "/Game/Res/Maps/";
    public static readonly string CardPath = Application.dataPath + "/Game/Res/Cards/";

    //存档
    public const string GameProgress = "GameProgress";

    //Model

    public const string M_GameModel = "M_GameModel";
    public const string M_RoundModel = "M_RoundModel";

    //View
    public const string V_Start = "V_Start";
    public const string V_Select = "V_Select";
    public const string V_UIBoard = "V_UIBoard";
    public const string V_UICountDown = "V_UICountDown";
    public const string V_UIwin = "V_UIwin";
    public const string V_UILost = "V_UILost";
    public const string V_UISystem = "V_UISystem";
    public const string V_UIComplete = "V_UIComplete";
    public const string V_Spawner = "V_Spawner";


    //Controller

    public const string E_StartUp = "E_StartUp";


    public const string E_EnterScene = "E_EnterScene"; //SceneArgs
    public const string E_ExitScene = "E_ExitScene";//SceneArgs

    public const string E_StartLevel = "E_StartLevel"; //StartLevelArgs
    public const string E_EndLevel = "E_EndLevel"; //EndLevelArgs

    public const string E_CountDownComplete = "E_CountDownComplete"; //EndLevelArgs

    public const string E_StartRound = "E_StartRound"; //StartRoundArgs
    public const string E_SpawnMonster = "E_SpawnMonster"; //MonsterArgs
}

public enum GameSpeed
{
    One,
    Two
}