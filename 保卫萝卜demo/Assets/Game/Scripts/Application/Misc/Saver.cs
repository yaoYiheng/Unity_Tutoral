using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Saver 
{
	public static int GetGameProgress()
	{
		return PlayerPrefs.GetInt(Const.GameProgress, -1);
	}
	public static void SetGameProgress(int levelIndex)
	{
		PlayerPrefs.SetInt(Const.GameProgress, levelIndex);
	}
}
