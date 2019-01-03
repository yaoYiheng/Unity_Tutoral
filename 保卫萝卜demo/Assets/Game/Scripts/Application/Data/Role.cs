using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public abstract class Role : ReusableObject, IReuseable
{

	#region 常量
	#endregion

	#region 事件
	public event Action<int, int> OnHealthPointChange;
	public event Action<Role> OnRoleDead;
	#endregion

	#region 字段
	int m_CurrentHP;
	int m_MaxHP;
	#endregion

	#region 属性
	//是否已经死亡.
	public bool IsDead
	{
		get{return m_CurrentHP <= 0;}
	}


	public Vector3 Position
	{
		set{transform.position = value;}
		get{return transform.position;}
	}
	public int CurrentHP
	{
		set
		{
			
			//设置血量
			//限定, 保证传入的血量是合法的
			m_CurrentHP = Mathf.Clamp(m_CurrentHP, 0, MaxHP);

			// 如果传入的血量与上次的一致, 则返回不需要进行修改
			if(value == m_CurrentHP) return;

			//设置血量后, 就需要将该事件发布.
			m_CurrentHP = value;

			//如果有监听者
			if(OnHealthPointChange != null) 
				OnHealthPointChange(m_CurrentHP, MaxHP);

			//如果血量为0, 则将发布死亡的事件.
			if(m_CurrentHP <= 0)
			{
				if(OnRoleDead != null)
				{
					OnRoleDead(this);
				}
				
			}	
				

		}

		get
		{
			return m_CurrentHP;
		}
	}

    public int MaxHP 
	{
		 get {return m_MaxHP;}

		set
		{
			if(value < 0) value = 0;
			m_MaxHP = value;
		}	
	}


    #endregion

    #region 方法

    public virtual void Damage(int damage)
	{
		if(IsDead) return;

		CurrentHP -= damage;
	}

	protected virtual void OnDead(Role role)
	{

	}
    #endregion

    #region Unity回调
    #endregion

    #region 事件回调
    public  override void OnSpawn()
	{
		//当出怪的时候, 为这个role绑定上事件
		this.OnRoleDead += OnDead;
	}

	public override void UnSpawn()
	{
		MaxHP = 0;
		CurrentHP = 0;

		//将事件内的监听器清空
		OnHealthPointChange = null;
		OnRoleDead = null;
	}
	#endregion

	#region 帮助方法
	#endregion
}