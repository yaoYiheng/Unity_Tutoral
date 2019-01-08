using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Consts
{
	public static string LevelPath = Application.dataPath + @"/Game/Resources/Res/Levels";
    public static string MapPath = Application.dataPath + @"/Game/Resources/Res/Maps/";


    //视图
    public const string V_Start = "V_Start";
    public const string V_Select = "V_Select";
    public const string V_Board = "V_Board";
    public const string V_CountDown = "V_CountDown";

    //控制器

    public const string E_StartUp = "E_StartUp"; //None Args

    public const string E_EnterScene = "E_EnterScene"; //SceneIndexArgs
    public const string E_ExitScene = "E_ExitScene";   //SceneIndexArgs


    //开始关卡
    public const string E_StartLevel = "E_StartLevel";
}

public enum GameSpeed
{
    SpeedOne,
    SpeedTwo
}