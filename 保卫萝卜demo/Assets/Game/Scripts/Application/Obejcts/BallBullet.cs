using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBullet : Bullet
{
	#region 常量
    #endregion

    #region 事件
    #endregion

    #region 字段

    #endregion

    #region 属性
    public Monster Target{get; private set;}
    public Vector3 Direction{get; private set;}
    #endregion

    #region 方法
    public void Load(int bulletID, int level, Rect mapRect, Monster target)
    {
        Load(bulletID, level, mapRect);
        Target = target;

        //计算方向
        Direction = (target.Position - transform.position).normalized;

    }
    #endregion

    #region Unity回调
    protected override void Update()
    {
        //如果子弹已经爆炸
        if(m_IsExposed) return;

        //如果目标存在
        if(Target!= null)
        {
            //如果怪物还活着
            if(!Target.IsDead)
            {
                //重新计算
                Direction = (Target.Position - transform.position).normalized;
            }
            else
            {
                print(Direction);
            }

            //朝向目标
            LookAt();

            // 朝目标移动
            transform.Translate(Direction * Time.deltaTime * this.Speed, Space.World);

            //当移动到目标旁时
            if(Vector3.Distance(transform.position, Target.Position) < Const.ClosedDistance)
            {
                //伤害
                Target.Damage(this.Attack);

                //播放爆炸
                Explode();
            }


        }
        else//目标已经死亡
        {
            // 目标死亡后, 继续向着最后一次计算的方向前进
            transform.Translate(Direction * Time.deltaTime * this.Speed, Space.World);

            // 范围检测, 飞出地图后爆炸
            if(!m_IsExposed && MapRect.Contains(transform.position))
                Explode();
        }

    }

    void LookAt()
    {
        float eularAngle = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;

        Vector3 tempAngel = transform.eulerAngles;

        tempAngel.z = eularAngle - 90;

        transform.eulerAngles = tempAngel;
    }
    #endregion

    #region 事件回调
    #endregion

    #region 帮助方法
    #endregion
}