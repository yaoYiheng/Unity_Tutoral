using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : ReusableObject, IReuseable
{
	#region 常量
	#endregion

	#region 事件
	#endregion

	#region 字段

	#endregion

	#region 属性
	public int BulletID{get; private set;}
	public int Level{get; private set;}
	public float BaseSpeed{get; private set;}
	public int BaseAttack{get; private set;}
	public float Speed{get{return BaseSpeed * Level;}}
	public int Attack{get{return BaseAttack * Level;}}
	public Rect MapRect{get; private set;}

	protected bool m_IsExposed;

	public float TimeToDelay = 1.0f;
	Animator m_Animator;
	#endregion

	#region 方法
	public void Load(int butlletID, int level, Rect rect)
	{
		BulletID = butlletID;
		Level = level;
		MapRect = rect;
		//根据ID从静态数据中获取数据
		BulletInfo info = Game.Instance.StaticData.GetBulletInfo(butlletID);
		this.BaseAttack = info.BaseAttack;
		this.BaseSpeed = info.BaseSpeed;
	}

	public void Explode()
	{
		//更改爆炸状态
		m_IsExposed = true;

		// 播放爆炸动画
		m_Animator.SetTrigger("IsExplode");

		// 开启携程延迟回收
		StartCoroutine(DelayRecycle());

	}

	IEnumerator DelayRecycle()
	{
		yield return new WaitForSeconds(TimeToDelay);

		//回收对象
		 Game.Instance.ObjectPool.UnSpawn(this.gameObject);
	}
	#endregion

	#region Unity回调
	protected virtual void Awake()
	{
		//获取到动画组件
		m_Animator = GetComponent<Animator>();
	}

	protected virtual void Update()
	{

	}

	#endregion

	#region 事件回调
	public override void OnSpawn()
	{

	}

	public override void UnSpawn()
	{
		//还原
		m_IsExposed = false;
		m_Animator.Play("Play");
		m_Animator.ResetTrigger("IsExplode");

	}
	#endregion

	#region 帮助方法
	#endregion


}
