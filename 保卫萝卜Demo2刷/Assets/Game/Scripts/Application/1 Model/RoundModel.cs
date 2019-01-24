using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundModel : Model
{

    #region 常量
    public const float MONSTER_INTERVIAL = 1.0f;
    public const float ROUNDS_INTERVIAL = 3.0f;
    #endregion

    #region 事件
    #endregion

    #region 字段
    //回合列表
    List<Round> m_Rounds = new List<Round>();
    //当前回合
    int m_CurrentRoundIndex = -1;


    bool m_IsCompleted = false;

    Coroutine m_RoundCoroutine;

    //bool m_Restarted = false;

    #endregion

    #region 属性

    public bool Restarted;
    //public IEnumerator RoundCoroutine
    //{
    //    get
    //    {
    //        return m_RoundCoroutine;
    //    }
    //}

    public int TotalRounds
    {
        get { return m_Rounds.Count; }
    }
    public bool IsCompleted
    {
        get
        {
            return m_IsCompleted;
        }
    }

    //当前回合
    public int CurrentRoundIndex
    {
        get
        {
            return m_CurrentRoundIndex;
        }
    }
    public override string Name
    {
        get
        {
            return Consts.M_RoundModel;
        }
    }


    #endregion

    #region 方法

    public void RestartRound()
    {
        m_CurrentRoundIndex = -1;
        m_IsCompleted = false;
        PauseRound();
    }
    public void LoadRounds(Level level)
    {
        m_Rounds = level.Rounds;
    }
    public void StartRound()
    {

        m_RoundCoroutine = Game.Instance.StartCoroutine(RunRound());
    }
    public void PauseRound()
    {
        Game.Instance.StopCoroutine(m_RoundCoroutine);
    }

    IEnumerator RunRound()
    {
        for (int i = 0; i < TotalRounds; i++)
        {
            m_CurrentRoundIndex = i;
            //回合开始时, 可以发送事件. 包含当前是第几波怪, 总共有几波怪
            StartRoundArgs args = new StartRoundArgs()
            {
                CurrentRound = CurrentRoundIndex + 1,
                TotalRounds = TotalRounds
            };
            SendEvent(Consts.E_StartRound, args);

            Round round = m_Rounds[i];
            //开始出怪
            for (int k = 0; k < round.Count; k++)
            {

                //出怪间隔
                yield return new WaitForSeconds(MONSTER_INTERVIAL);
                //创建事件参数
                SpawnMonsterArgs ee = new SpawnMonsterArgs() { MonsterID = round.MonsterID };
                //发布出怪事件
                SendEvent(Consts.E_SpawnMonster, ee);



                //加判断是否出完最后一波怪的最后一个
                if (i == TotalRounds - 1 && k == round.Count - 1) m_IsCompleted = true;

            }

            if(!IsCompleted)
            {
                yield return new WaitForSeconds(ROUNDS_INTERVIAL);
            }
        }
    }
    #endregion

    #region Unity回调
    #endregion

    #region 事件回调
    #endregion

    #region 帮助方法
    #endregion

}
