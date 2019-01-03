﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public static class Const 
{

    //参数
    public const float ClosedDistance = 0.1f;
    public const float RangeClosedDistance = 0.5f;

    //目录
    public static readonly string LevelPath = Application.dataPath + "/Game/Resources/Res/Levels/";
    public static readonly string MapPath = Application.dataPath + "/Game/Resources/Res/Maps/";
    public static readonly string CardPath = Application.dataPath + "/Game/Resources/Res/Cards/";
    public static readonly string ImgPath = Application.dataPath + "/Game/Resources/Res/Roles/";

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
    public const string V_UIWin = "V_UIwin";
    public const string V_UILost = "V_UILost";
    public const string V_UISystem = "V_UISystem";
    public const string V_UIComplete = "V_UIComplete";
    public const string V_Spawner = "V_Spawner";

    public const string V_TowerPopup = "V_TowerPopup";


    //Controller

    public const string E_StartUp = "E_StartUp";


    public const string E_EnterScene = "E_EnterScene"; //SceneArgs
    public const string E_ExitScene = "E_ExitScene";//SceneArgs

    public const string E_StartLevel = "E_StartLevel"; //StartLevelArgs
    public const string E_EndLevel = "E_EndLevel"; //EndLevelArgs

    public const string E_CountDownComplete = "E_CountDownComplete"; //EndLevelArgs

    public const string E_StartRound = "E_StartRound"; //StartRoundArgs
    public const string E_SpawnMonster = "E_SpawnMonster"; //MonsterArgs

    public const string E_ShowCreatPanel = "E_ShowCreatPanel";
    public const string E_ShowUpgradePanel = "E_ShowUpgradePanel";
    public const string E_HideAllPanel = "E_HideAllPanel";

    public const string E_SpawnWeapon = "E_SpawnWeapon"; //SpawnWeaponArgs
    public const string E_UpgradeWeapon = "E_UpgradeWeapon"; //UpgradeWeaponArgs
    public const string E_SellWeapon = "E_SellWeapon"; //SellWeaponArgs


    //方法
    public const string F_SpawnWeapon = "SpawnWeapon";
    public const string F_UpgradeWeapon = "UpgradeWeapon";
    public const string F_SellWeapon = "SellWeapon";
}

public enum GameSpeed
{
    One,
    Two
}
public enum MonsterType
{
    
    Monster0, 
    Monster1, 
    Monster2, 
    Monster3, 
    Monster4, 
    Monster5 

}