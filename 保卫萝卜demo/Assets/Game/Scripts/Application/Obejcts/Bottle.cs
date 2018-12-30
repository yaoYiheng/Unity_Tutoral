using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : Tower
{
	 protected override void Attack()
	 {
		 //当攻击时, 实现攻击的动画
		 m_Animator.SetTrigger("IsAttack");

		 //播放音效
		 
	 }

	 public override void OnSpawn()
	 {
		 base.OnSpawn();
	 }

	 public override void UnSpawn()
	 {
		 base.UnSpawn();
	 }

}
