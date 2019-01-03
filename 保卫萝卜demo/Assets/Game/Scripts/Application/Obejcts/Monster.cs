using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Monster : Role
{

	#region 常量
	public const float CLOSED_DISTANCE = 0.1f;
	#endregion

	#region 事件
	public event Action<Role> OnReached;
	#endregion

	#region 字段
	Vector3[] m_Path = null;

	int m_CurrentIndex = -1;
	public MonsterType MonsterType = MonsterType.Monster0;
	float m_MoveSpeed;
	bool m_IsReached;
	#endregion

	#region 属性
	public float MoveSpeed
	{
		set{m_MoveSpeed = value;}

		get{return m_MoveSpeed;}
	}

	#endregion

	#region 方法

	//加载怪物行走的路径
	public void LoadPath(Vector3[] path)
	{
		m_Path = path;
		//当加载完路径之后, 就调用一次MoveNext
		MoveNext();
	}
	void MoveTo(Vector3 position)
	{
		transform.position = position;
	}

	public bool IsReached
	{
		set{m_IsReached = value;}
		get
		{
			return m_IsReached;
		}
	}
	void MoveNext()
	{
		if (!HasNext()) return;

		// 如果是刚生成出来的第一个就将位置移动待行进路径数组中的第一个点
		if (m_CurrentIndex == -1)
		{
			m_CurrentIndex = 0;
			MoveTo(m_Path[m_CurrentIndex]);
		}
		else
		{
			m_CurrentIndex++;
		}
	}
	public bool HasNext()
	{
		return m_Path.Length - m_CurrentIndex >= 2;
	}
	protected override void OnDead(Role role)
	{

	}
	#endregion

	#region Unity回调
	private void Update()
	{
		if(IsReached) return;




		Vector3 position = transform.position;

		Vector3 destination = m_Path[m_CurrentIndex];

		float distance = Vector3.Distance(position, destination);

		if(distance < CLOSED_DISTANCE)
		{
			MoveTo(destination);
			//判断是否还有下一站
			if(HasNext())
			{
				MoveNext();
			}
			else
			{
				//没有下一站了就发将事件发布
				m_IsReached = true;
				if(OnReached != null)
				{
					OnReached(this);
				}
			}
		}
		else
		{
			Vector3 direction = (destination - position).normalized;
			transform.Translate(direction * Time.deltaTime * m_MoveSpeed);
		}
	}

	#endregion

	#region 事件回调
	public override void OnSpawn()
	{
		base.OnSpawn();
		MonsterInfo info = StaticData.Instance.GetMonsterInfo((int)MonsterType);

		this.MaxHP = info.HealthPoint;
		this.CurrentHP = info.HealthPoint;
		this.MoveSpeed = info.MoveSpeed;

	}

	public override void UnSpawn()
	{
		base.UnSpawn();

		this.IsReached = false;
		this.MoveSpeed = 0;
		this.m_CurrentIndex = -1;
		this.m_Path = null;
		this.OnReached = null;
	}

	#endregion

	#region 帮助方法

	#endregion
}
