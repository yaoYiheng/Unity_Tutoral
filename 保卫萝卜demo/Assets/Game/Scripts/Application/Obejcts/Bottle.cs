using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : Tower
{
	//
	Transform m_SpawnPoint;
	protected override void Awake()
	{
		base.Awake();
		m_SpawnPoint = transform.Find("SpawnPoint");
	}
	 protected override void Attack(Monster target)
	 {
		 //当攻击时, 实现攻击的动画
		//  m_Animator.SetTrigger("IsAttack");
		base.Attack(target);
		//
		GameObject go = Game.Instance.ObjectPool.OnSpawn("BallBullet");
		DontDestroyOnLoad(go);
		BallBullet bullet = go.GetComponent<BallBullet>();

		//从发射点发射
		bullet.transform.position = m_SpawnPoint.transform.position;
		//加载子弹所需要的数据
		bullet.Load(this.BulletID, this.CurrentLevel, this.MapRect, target);


		 //播放音效
		 
	 }



}
