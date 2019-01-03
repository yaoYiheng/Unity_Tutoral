using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanBullet : Bullet
{
    public float RotateSpeed = 180.0f;

    // 子弹前进方向
    public Vector3 Direction{get; private set;}

    //加载子弹所需要的数据
    public void Load(int bulletId, int level, Rect mapRect, Vector3 direction)
    {
        Load(bulletId, level, mapRect);

        Direction = direction;
    }
    protected override void Update()
    {
        if(m_IsExposed) return;

        //旋转
        transform.Rotate(Vector3.forward, Time.deltaTime * RotateSpeed, Space.World);

        // 朝着方向前进
        transform.Translate(Direction * this.Speed * Time.deltaTime, Space.World);
        // 对怪物做碰撞检测

        GameObject[] objects = GameObject.FindGameObjectsWithTag("Monster");
        foreach (GameObject item in objects)
        {
            Monster monster = item.GetComponent<Monster>();

            float dis = Vector3.Distance(monster.Position, transform.position);
            if(!monster.IsDead && dis <= Const.RangeClosedDistance)
            {
                monster.Damage(this.Attack);
                Explode();

                break;
            }
        }

        if(!m_IsExposed && !MapRect.Contains(transform.position))
            Explode();

        //没有碰到怪物时, 飞到边界外爆炸


    }
}