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
	Monster m_Target = null;

	float m_LastFireTime = 0f;
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
		 m_Animator.SetTrigger("IsAttack");
	}

	void LookAtTarget(Monster target)
	{
		print("调用");
		//如果目标为空.
		if(target == null)
		{
			Vector3 angle = transform.eulerAngles;
			angle.z = 0;
			transform.eulerAngles = angle;
		}
		else
		{
			//计算目标与塔之间的矢量
			Vector3 dis = (target.Position - transform.position).normalized;

			//获取到该矢量的弧度, 并将该弧度转换成角度
			float randians = Mathf.Atan2(dis.y, dis.x);

			Vector3 angle = transform.eulerAngles;
			angle.z = randians * Mathf.Rad2Deg;// - 90f;
			transform.eulerAngles = angle;

		}
	}
	#endregion

	#region Unity回调
	void Update()
	{
		//使炮塔始终朝着目标
		LookAtTarget(m_Target);
		//在每一帧的调用中判断Tower的目标
		if(m_Target == null)//当目标为空时
		{
			//获取场景中的怪物
			GameObject[] monsters = GameObject.FindGameObjectsWithTag("Monster");

			//变量怪物数组, 将没有死亡且在攻击范围内的对象设置为攻击对象
			foreach(GameObject m in monsters)
			{
				//在获取的游戏对象上, 获取到对应的组件
				Monster monster = m.GetComponent<Monster>();

				//计算怪物与当前炮塔的距离
				float distance = Vector3.Distance(monster.transform.position, transform.position);

				if (!monster.IsDead && distance < this.AttactArea)
				{
					//找到目标
					m_Target = monster;
					//跳出当前循环
					break;	
				}
			}
		}
		else//当找到目标时
		{
			// 能来到该语句, 说明在上一帧中已经获取到了目标
			// 在这一帧开始时, 还是需要判断, 在这一帧中 怪物是否死亡以及是否跑到攻击范围之外
			float distance = Vector3.Distance(m_Target.transform.position, transform.position);
			if(!m_Target.IsDead && distance > this.AttactArea)
			{
				//放弃目标
				m_Target = null;
				//返回
				return;
			}

			//根据设定的开火速率对目标发起攻击
			//下次攻击时间
			float nextFire = m_LastFireTime + 1f / this.FireRate;
			// 如果该时间满足条件则对怪物发动攻击
			if(Time.time >= nextFire)
			{
				Attack();

				//记录最后一次的攻击时间
				m_LastFireTime = Time.time;
			} 

		}
	}

	#endregion

	#region 事件回调
	public override void OnSpawn()
	{
		m_Animator = GetComponent<Animator>();
		//当出厂的时候, 就播放idle动画
		// m_Animator.Play("Idle");
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