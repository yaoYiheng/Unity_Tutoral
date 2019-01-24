using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleTower : Tower
{

    Transform m_SpawnPoint;
    public override void Attack(Monster monster)
    {
        base.Attack(monster);


        BulletInfo bulletInfo = Game.Instance.StaticData.GetBulletInfo(this.BulletID);
        //当攻击怪物时. 生成子弹
        GameObject bulletGo = Game.Instance.ObjectPool.OnSpawn(bulletInfo.PrefabName);
        DontDestroyOnLoad(bulletGo);
        BallBullet ballBullet = bulletGo.GetComponent<BallBullet>();
        ballBullet.transform.position = m_SpawnPoint.position;

        ballBullet.LoadBullet(this.BulletID, this.Level, this.MapRect, monster);


    }

    protected override void Awake()
    {
        base.Awake();
        m_SpawnPoint = transform.Find("SpawnPoint");
    }
}
