using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
/// <summary>
/// 这个类负责游戏数据的加载
/// 以及 当前玩的是哪一个关卡
/// 存档
/// </summary>
public class GameModel : Model
{

    #region 常量
    #endregion

    #region 事件
    #endregion

    #region 字段
    int m_Gold = 0;

    bool m_IsPlaying = false;

    List<Level> m_Levels = new List<Level>();

    int m_CurrentPlayingIndex = -1; //当前玩的关卡
    int m_GameProgress = -1;//玩的最大关卡.

    bool m_IsInit = false;
    #endregion

    #region 属性
    public override string Name
    {
        get
        {
            return Consts.M_GameModel;
        }
    }

    public int Gold { get { return m_Gold; }  set { m_Gold = value; } }

    public bool IsPlaying { get { return m_IsPlaying; } set { m_IsPlaying = value; } }
    //游戏进度关卡
    public int GameProgress { get { return m_GameProgress; }}
    //所有的关卡类
    public List<Level> AllLevels{ get { return m_Levels; }}
    //游戏总关卡数
    public int AllLevelsCount { get { return m_Levels.Count; }}
    //是否已经通过
    public bool IsPass{ get { return GameProgress > AllLevelsCount; }}
    //当前正在玩的游戏关卡
    public int CurrentPlayingIndex { get { return m_CurrentPlayingIndex; }}
    //是否已经完成初始化
    public bool IsInit { get { return m_IsInit; } set { m_IsInit = value; }}
    public Level CurrerntLevel { get { return m_Levels[CurrentPlayingIndex]; }}

    #endregion

    #region 方法
    public void Init()
    {
        //防止多次初始化
        if (IsInit) return;

        //加载游戏所需要的数据
        //赋值
        List<FileInfo> fileInfos = Tools.GetLevelFiels();

        foreach (var item in fileInfos)
        {
            Level level = new Level();
            Tools.FillLevel(item.FullName, ref level);
            m_Levels.Add(level);
        }
        //读取游戏当前进度
        m_GameProgress = 4;//Saver.GetGameProgress();

        IsInit = true;
    }

    //当游戏开始的时候, 标记游戏开始.记录当前开始的是那一关卡
    public void StartLevel(int level)
    {
        //IsPlaying = true;
        m_CurrentPlayingIndex = level;
    }

    //当游戏结束的时候, 标记游戏结束. 
    //外界调用, 将会传入游戏结束时的结果. 是赢还是输.
    //并且 根据将游戏进度与当前玩的关卡进行比较, 更新存档
    public void EndLevel(bool isWin)
    {
        if (isWin && CurrentPlayingIndex > GameProgress)
        {
            //保存存档
            Saver.SetGameProgress(CurrentPlayingIndex);
            //更新当前游戏进度
            m_GameProgress = Saver.GetGameProgress();
        }
        IsPlaying = false;
    }
    #endregion

    #region Unity回调
    #endregion

    #region 事件回调
    #endregion

    #region 帮助方法
    #endregion



}
