using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : Tower
 {

	 public int BulletCount = 10;
	protected override void Attack(Monster target)
	{
		base.Attack(target);

		for (int i = 0; i < BulletCount; i++)
		{
			// 使用系统自带的数学类, 知道角度求对应边的长度, 需要使用弧度进行计算
			float radians = Mathf.PI * 2 / BulletCount * i;
			Vector3 direcition = new Vector3(Mathf.Cos(radians), Mathf.Sin(radians), 0);

			GameObject go = Game.Instance.ObjectPool.OnSpawn("FanBullet");
			DontDestroyOnLoad(go);
			FanBullet fanBullet = go.GetComponent<FanBullet>();
			fanBullet.transform.position = this.transform.position;
			fanBullet.Load(this.BulletID, this.CurrentLevel,this.MapRect, direcition);	
		}

		
	}
}
