using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanTower : Tower
{
    private int bulletCount = 4;

    public override int Level
    {
        get
        {
            return base.Level;
        }

        set
        {
            base.Level = value;

            BulletCount += Level;
        }
    }
    public int BulletCount
    {
        get
        {
            return bulletCount;
        }

        set
        {
            bulletCount = value;
        }
    }

    public override void Attack(Monster monster)
    {
        base.Attack(monster);


        for (int i = 0; i < BulletCount; i++)
        {

            var angle = (Mathf.PI * 2 / BulletCount) * i;

            var direction = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0);

            BulletInfo bulletInfo = Game.Instance.StaticData.GetBulletInfo(BulletID);
            //生成子弹
            GameObject fanGo = Game.Instance.ObjectPool.OnSpawn(bulletInfo.PrefabName);
            DontDestroyOnLoad(fanGo);

            FanBullet fanBullet = fanGo.GetComponent<FanBullet>();
            fanBullet.transform.position = transform.position;
            fanBullet.LoadBullet(BulletID, Level, MapRect, direction);
        }



    }


}
