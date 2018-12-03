using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System;

public class GameModel : Model
{

	#region 常量
    #endregion

    #region 事件
    #endregion

    #region 字段
	//最大的通关索引
	int m_GameProgress = -1;

	//当前正在进行的关卡索引
	int m_PlayingLevelIndex = -1;

    int m_Score = 0;
    bool m_IsPlaying = false;
	//所有的关卡
	List<Level> m_AllLevels = new List<Level>();
    #endregion

    #region 属性
	    public override string Name
    {
        get
        {
			return Const.M_GameModel;
        }
    }


    public List<Level> AllLevels 
    { 
        get {return m_AllLevels;}
    }

    //当前正在玩的游戏Level
    public Level PlayingLevel
    {
        get
        {
            if(PlayingLevelIndex < 0 || PlayingLevelIndex > m_AllLevels.Count - 1)
            {
                throw new IndexOutOfRangeException("关卡不存在");
            }

            return m_AllLevels[PlayingLevelIndex];
        }
    }


    //是否通关
    //当最大游戏关数>=关卡数量时, 就表示游戏通关
    public bool IsPassed
    {
        get{return GameProgress >= LevelCount;}
    }
    //关卡数量
    public int LevelCount
    {
        get{return m_AllLevels.Count;}
    }
    public int Score { get{return m_Score; }  set{ m_Score = value;}}
    public bool IsPlaying { get{return m_IsPlaying;} set { m_IsPlaying = value; }}
    public int GameProgress { get {return m_GameProgress;}}
    public int PlayingLevelIndex { get {return m_PlayingLevelIndex;}}



    #endregion

    #region 方法
    public void Initialize()
	{

		//将文件列表加载到内存
		List<FileInfo> fileInfos = Tools.GetLevelFiels();

		List<Level> levels = new List<Level>();

		foreach (FileInfo item in fileInfos)
		{
			Level level = new Level();

			Tools.FillLevelFromFile(item.FullName, ref level);

			levels.Add(level);
		}

        //读取游戏进度
        m_GameProgress = Saver.GetGameProgress();

		//将获得的Level类对象保存到列表
		m_AllLevels = levels;



	}
	
    //保存即将要玩的level的索引.
    //游戏开始.
    public void StartLevel(int level)
    {
        m_PlayingLevelIndex = level;
    }

    //关卡结束时, 进行统计, 有没有过关, 是否有必要检查存档.
    public void EndLevel(bool IsPassed)
    {
        //当当前玩的关卡大于游戏最大关卡时, 如果赢了, 就保存游戏进度
        if(IsPassed && PlayingLevelIndex > GameProgress)
        {
            Saver.SetGameProgress(PlayingLevelIndex);
        }

  
    }

    //清档.还原
    public void ClearProgress()
    {
        m_PlayingLevelIndex = -1;
        m_GameProgress = -1;
        m_IsPlaying = false;
        Saver.SetGameProgress(-1);
    }
    #endregion

    #region Unity回调
    #endregion

    #region 事件回调
    #endregion

    #region 帮助方法
    #endregion

}