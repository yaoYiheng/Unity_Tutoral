using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public static class Const 
{
    //目录
    public static readonly string LevelPath = Application.dataPath + "/Game/Res/Levels/";
    public static readonly string MapPath = Application.dataPath + "/Game/Res/Maps/";

    //存档


    //Model



    //View
    public const string V_Start = "V_Start";
    public const string V_Select = "V_Select";

    //Controller

    public const string E_StartUp = "E_StartUp";


    public const string E_EnterScene = "E_EnterScene"; //SceneArgs
    public const string E_ExitScene = "E_ExitScene";//SceneArgs

    public const string E_StartLevel = "E_StartLevel"; //StartLevelArgs
    public const string E_EndLevel = "E_EndLevel"; //EndLevelArgs


}