using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Consts
{
	public static string LevelPath = Application.dataPath + @"/Game/Resources/Res/Levels";
    public static string MapPath = Application.dataPath + @"/Game/Resources/Res/Maps/";


    //视图
    public static string V_Start = "V_Start";
    public static string V_Select = "V_Select";

    //控制器

    public static string E_StartUp = "E_StartUp"; //None Args

    public static string E_EnterScene = "E_EnterScene"; //SceneIndexArgs
    public static string E_ExitScene = "E_ExitScene";   //SceneIndexArgs

}