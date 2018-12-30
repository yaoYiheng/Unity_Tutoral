using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower: Role
{
	#region 常量

	#endregion

	#region 事件

	#endregion

	#region 字段
	int m_CurrentLevel;
	
	protected Animator m_Animator;
	
	GridInfo m_GridInfo;
	Monster m_Target;

	#endregion

	#region 属性

	public int TowerID{get; private set;}

	public int Price{get {return BasePrice * CurrentLevel;}}
	public int BasePrice{get; private set;}

	//当前等级
	public int CurrentLevel
	{	
		get{ return m_CurrentLevel;}
		set
		{	//对当前等级进行限制
			m_CurrentLevel = Mathf.Clamp(value, 0, MaxLevel);
			
			//根据当前等级设置大小
			transform.localScale = Vector3.one * (1 + CurrentLevel * 0.25f);
		}
	}
	public int MaxLevel{get; private set;}
	public bool IsMaxLevel
	{
		get {return CurrentLevel >= MaxLevel;}
	}

	public float FireRate{get; private set;}
	public int BulletID{get; private set;}

	//攻击范围
	public float AttactArea{get; private set;}


	#endregion

	#region 方法
	public void Load(int towerID, GridInfo grid)
	{
		//通过ID获取数据
		WeaponInfo info = Game.Instance.StaticData.GetWeaponInfo(towerID);
		this.MaxLevel = info.MaxLevel;
		this.FireRate = info.FireRate;
		this.BasePrice = info.BasePrice;
		this.AttactArea = info.AttactArea;
		this.BulletID = info.BulletID;
		this.CurrentLevel = 1;

		m_GridInfo = grid;

	}
	protected virtual void Attack()
	{

	}
	#endregion

	#region Unity回调

	#endregion

	#region 事件回调
	public override void OnSpawn()
	{
		m_Animator = GetComponent<Animator>();
	}
	
	public override void UnSpawn()
	{
		//重置动画
		m_Animator.ResetTrigger("IsAttack");
		m_Animator = null;
		
		//清除目标
		m_Target = null;
		this.CurrentLevel = 0;
		this.TowerID = 0;
		this.BasePrice = 0;
		this.MaxLevel = 0;
		this.AttactArea = 0;
		this.BulletID = 0;

	}

	#endregion

	#region 帮助方法

	#endregion
}