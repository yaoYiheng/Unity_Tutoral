using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBullet : Bullet
{
    //Monster Target;

    public Monster Target { get; set; }
    public Vector3 Direction { get; private set; }

    Vector3 last;
    public void LoadBullet(int bulletID, int towerLevel, Rect mapRect, Monster target)
    {
        LoadData(bulletID, towerLevel, mapRect);
         Target = target;

        //计算子弹前进的方向
        Direction = (Target.Position - this.transform.position).normalized;
    }



    protected override void Update()
    {
        if (m_IsExploded) return;

        if (Target!=null)
        {
            if(!Target.IsDead)
            {
                //计算方向
                Direction = (Target.Position - this.transform.position).normalized;
                last = Direction;
            }
            else
            {
                //死亡后子弹向最后的方向飞去.
                Target = null;
                transform.Translate(last * this.Speed * Time.deltaTime, Space.World);
                //Explode();
                return;
            }

            LookAt();

            //朝着目标移动

            transform.Translate(Direction * this.Speed *Time.deltaTime, Space.World);

            if (Vector3.Distance(Target.Position, transform.position) < 0.3f)
            {
                Target.OnDamage(this.AttackPoint);
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
