using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luobo : Role
 {
	#region 常量

	#endregion

	#region 事件

	#endregion

	#region 字段
	private Animator m_Animator = null;

	#endregion

	#region 属性

	#endregion

	#region 方法
	public override void Damage(int damage)
	{
		
		//当收到攻击时
		if (!IsDead)
		{	
			m_Animator.SetTrigger("IsDamage");
		}
		base.Damage(damage);
	}
	protected override void OnDead(Role role)
	{
		base.OnDead(role);

		m_Animator.SetBool("IsDead", true);
	}

	#endregion

	#region Unity回调

	#endregion

	#region 事件回调
	public override void OnSpawn()
	{
		base.OnSpawn();

		m_Animator = GetComponent<Animator>();
		m_Animator.Play("Idle");
		LuoboInfo luobo = Game.Instance.StaticData.GetLuoBoInfo();
		this.MaxHP = luobo.HealthPoint;
		this.CurrentHP = luobo.HealthPoint;

	}


	public override void UnSpawn()
	{
		base.UnSpawn();
		this.MaxHP = 0;
		this.CurrentHP = 0;
		m_Animator.ResetTrigger("IsDamage");
		m_Animator.SetBool("IsDead", false);
	}
	#endregion

	#region 帮助方法

	#endregion
}
