using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanBullet : Bullet 
{
    public float RotateSpeed = 180.0f;
    public Vector3 Direction { get; private set; }

    public void LoadBullet(int bulletId, int level, Rect mapRect, Vector3 direction)
    {
        base.LoadData(bulletId, level, mapRect);

        Direction = direction;
    }

    protected override void Update()
    {
        //如果已经爆炸就返回
        if (m_IsExploded) return;

        //自转
        transform.Rotate(Vector3.forward, RotateSpeed * Time.deltaTime);

        //向前进的方向
        transform.Translate(Direction * Speed * Time.deltaTime, Space.World);

        GameObject[] monsters = GameObject.FindGameObjectsWithTag("Monster");

        foreach (var item in monsters)
        {
            var monster = item.GetComponent<Monster>();

            //忽略已经死掉的怪物
            if (monster.IsDead) continue;

            if (Vector3.Distance(monster.Position, transform.position) < Consts.CloseRange)
            {
                //怪物掉血
                monster.OnDamage(this.AttackPoint);
                Explode();

            }
        }

        if (!m_IsExploded && !MapRect.Contains(transform.position)) Explode();

    }       
}
