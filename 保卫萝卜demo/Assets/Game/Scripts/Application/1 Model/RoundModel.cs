using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundModel : Model
 {
    

	#region 常量
	public const float ROUND_INTERVAL = 3.0f;
	public const float SPAWN_INTERVAL = 1.0f;
	#endregion

	#region 事件
	#endregion

	#region 字段
	List<Round> m_Rounds = new List<Round>();
	int m_CurrentRoundInex = -1;
	bool m_IsAllCompleted = false;

	Coroutine m_Coroutine;
	#endregion

	#region 属性

	public int TotalRound
	{
		get{return m_Rounds.Count;}
	}
	public override string Name 
	{
		get{return Const.M_RoundModel;}
	}

    public int CurrentRoundInex
	{
		 get {return m_CurrentRoundInex;}
	}

    public bool IsAllCompleted { get {return m_IsAllCompleted;}}

    #endregion

    #region 方法
    public void LoadRoundFromLevel(Level level)
	{
		m_Rounds = level.Rounds;
		m_CurrentRoundInex = -1;
		m_IsAllCompleted = false;
	}
	public void StartRound()
	{
		Debug.Log("开始出怪");
		m_Coroutine = Game.Instance.StartCoroutine(RunRound());
	}
	public void EndRound()
	{
		Game.Instance.StopCoroutine(m_Coroutine);
	}

	//通过携程发送出怪的事件
	IEnumerator RunRound()
	{

		m_CurrentRoundInex = -1;
		m_IsAllCompleted = false;
		for (int i = 0; i < m_Rounds.Count; i++)
		{
			m_CurrentRoundInex = i;
			//发布每一波的事件

			RoundArgs args = new RoundArgs();

			args.CurrentRound = m_CurrentRoundInex;
			args.TotalRound = m_Rounds.Count;
			SendEvent(Const.E_StartRound, args);

			Round round = m_Rounds[i];
			for (int j = 0; j < round.Count; j++)
			{
								
				//每一个怪物之间的间隔
				yield return new WaitForSeconds(SPAWN_INTERVAL);
				MonsterArgs mArgs = new MonsterArgs();
				mArgs.MonsterID = round.MonsterID;

				SendEvent(Const.E_SpawnMonster, mArgs);

				// 当完成了最后一波的最后一个怪时, 就更改状态
				if(i == m_Rounds.Count - 1 && j == round.Count - 1)
				{
					m_IsAllCompleted = true;
				}

			}
			
			// m_CurrentRoundInex++; //2019.1.2修改bug时注释掉
			// if(i < m_Rounds.Count - 1)
			// 	//每一波怪物之间的间隔;
			if(!m_IsAllCompleted)
			{
				yield return new WaitForSeconds(ROUND_INTERVAL);
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
