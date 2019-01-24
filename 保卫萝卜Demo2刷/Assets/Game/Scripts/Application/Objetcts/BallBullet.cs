using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBullet : Bullet
{
    Monster m_Target;
    public Vector3 Direction { get; private set; }


    public void LoadBullet(int bulletID, int towerLevel, Rect mapRect, Monster target)
    {
        LoadData(bulletID, towerLevel, mapRect);
         m_Target = target;

        //计算子弹前进的方向
        Direction = (target.Position - this.transform.position).normalized;
    }



    protected override void Update()
    {
        if (m_IsExploded) return;

        if (m_Target!=null)
        {
            if(!m_Target.IsDead)
            {
                //计算方向
                Direction = (m_Target.Position - this.transform.position).normalized;
            }

            LookAt();

            //朝着目标移动

            transform.Translate(Direction * this.Speed *Time.deltaTime, Space.World);

            if (Vector3.Distance(m_Target.Position, transform.position) < 0.1f)
            {
                m_Target.OnDamage(this.AttackPoint);
                Explode();


            }
        }
        else
        {
            transform.Translate(Direction * this.Speed * Time.deltaTime, Space.World);
            //如果飞出地图则爆炸
            if (!m_IsExploded && !this.MapRect.Contains(transform.position))
                Explode();
        }
    }

    void LookAt()
    {
        var temp = Mathf.Atan2(Direction.y, Direction.x);
        var tempAnge = temp * Mathf.Rad2Deg - 90;

        var eularAngle = transform.eulerAngles;
        eularAngle.z = tempAnge;

        transform.eulerAngles = eularAngle;
    }
}
