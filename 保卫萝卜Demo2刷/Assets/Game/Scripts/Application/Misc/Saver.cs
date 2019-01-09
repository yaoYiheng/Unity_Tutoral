using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 该类用于存储游戏进度
/// </summary>
public static class Saver 
{
    public static void SetGameProgress(int currentLevel)
    {
        PlayerPrefs.SetInt(Consts.GameProgress, currentLevel);
    }

    public static int GetGameProgress()
    {
        return PlayerPrefs.GetInt(Consts.GameProgress, -1);
    }
}
