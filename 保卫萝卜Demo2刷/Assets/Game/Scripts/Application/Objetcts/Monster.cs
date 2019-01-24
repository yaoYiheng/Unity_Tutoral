using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Role
{

    #region 常量
    public const float DISTANCE = 0.1f;
    #endregion

    #region 事件

    public event Action<Monster> Reach;
    #endregion

    #region 字段
    int m_MoveSpeed;

    Vector3[] m_Path = null;

    bool m_IsReached = false;

    public MonsterType MonsterType = MonsterType.monsterOne;

    int m_CurrentIndex = -1;

    int m_MonsterID;
    #endregion

    #region 属性
    public int MonsterID{ get { return m_MonsterID; }}
    #endregion

    #region 方法

    public void LoadPath(Vector3[] vector3s)
    {
        m_Path = vector3s;
        print(vector3s.Length);
        MoveNext();

    }
    public int MoveSpeed
    {
        get
        {
            return m_MoveSpeed;
        }

        set
        {
            m_MoveSpeed = value;
        }
    }

    bool HasNext()
    {
        return m_Path.Length - m_CurrentIndex > 1;
    }

    void MoveTo(Vector3 position)
    {
        Position = position;
    }
    void MoveNext()
    {
        if (!HasNext()) return;

        if(m_CurrentIndex == -1)
        {
            m_CurrentIndex = 0;
            MoveTo(m_Path[m_CurrentIndex]);
        }
        else
        {
            m_CurrentIndex++;   
        }
    }
    #endregion

    #region Unity回调
    private void Update()
    {


        //如果已经到达了目的地就返回

        if (m_IsReached) return;

        // 判断当前点与目的地的距离
        Vector3 currentPos = transform.position;
        Vector3 DesPos = m_Path[m_CurrentIndex];

        float distance = Vector3.Distance(currentPos, DesPos);

        //当两者间距离小于固定值时. 就直接调用MoveTo方法移动到下一个目的
        if (distance < DISTANCE)
        {
            MoveTo(DesPos);

            //需要进行判断. 是否还能继续向前
            if (HasNext())
            {
                //可以继续前进的话, 向下移动
                MoveNext();
            }
            else
            {
                //更改旗子
                m_IsReached = true;
                //能来到这里, 说明已经是到达最后一个点.发布到达事件
                //当到达目标的时候. 需要对事件进行监听
                if (Reach != null)
                    Reach(this);
            }

        }//如果两者之间的距离大于固定值, 则继续向目的地移动.
        else
        {
            //求得移动的方向
            Vector3 direction = (DesPos - currentPos).normalized;
            transform.Translate(direction * MoveSpeed * Time.deltaTime);
        }




    }

    #endregion

    #region 事件回调

    public override void OnSpawn()
    {
        base.OnSpawn();
        //当出厂的时候, 获取静态数据初始化

        //怪物类型作为ID获取到对应的信息
        MonsterInfo monsterInfo = StaticData.Instance.GetMonsterInfo((int)MonsterType);

        // 当前血量是基于最大血量, 需要先设置最大血量
        m_MonsterID = monsterInfo.MonsterID;
        this.MaxHP = monsterInfo.HealthPoint;
        this.CurrentHP = monsterInfo.HealthPoint;

        this.MoveSpeed = monsterInfo.MoveSpeed;
    }

    public override void UnSpawn()
    {
        base.UnSpawn();

        this.m_Path = null;
        this.m_CurrentIndex = -1;
        this.m_IsReached = false;
        this.m_MoveSpeed = 0;
        this.Reach = null;

    }
    #endregion

    #region 帮助方法
    #endregion

}
