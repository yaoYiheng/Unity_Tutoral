using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Role : ReusableObejct, IReusable
{

    #region 常量
    #endregion

    #region 事件
    public event Action<int, int> HealthChange;
    public event Action<Role> Dead;
    #endregion

    #region 字段
    [SerializeField]
    int m_CurrentHP;
    [SerializeField]
    int m_MaxHP;


    #endregion

    #region 属性
    //是否死亡
    public bool IsDead
    {
        get { return m_CurrentHP <= 0; }
    }
    // 角色的位置
    public Vector3 Position
    {
        set { transform.position = value; }
        get { return transform.position; }
    }
    //当前生命值
    public int CurrentHP
    {
        get
        {
            return m_CurrentHP;
        }

        set
        {
            //限定血量的范围
            value = Mathf.Clamp(value, 0, MaxHP);

            //减少重复赋值
            if (value == m_CurrentHP) return;

            m_CurrentHP = value;

            //能来到这里说明受到了伤害
            //对事件进行监听
            if (HealthChange != null)
            {
                HealthChange(m_CurrentHP, m_MaxHP);
            }

            // 如果血量为0, 发布死亡事件
            if (m_CurrentHP == 0)
            {
                if(Dead != null)
                {
                    Dead(this);
                }
            }
        }
    }

    public int MaxHP
    {
        get
        {
            return m_MaxHP;
        }

        set
        {
            if (value < 0)
            {
                value = 0;
            }
            m_MaxHP = value;
        }
    }

    #endregion

    #region 方法
    //提供给子类重写的受伤方法
    public virtual void OnDamage(int amount)
    {
        //死掉就返回
        if (IsDead) return;

        CurrentHP -= amount;
    }
    //供子类重写的

    public virtual void Role_Dead(Role obj)
    {
        
    }


    #endregion

    #region Unity回调
    #endregion

    #region 事件回调

    public override void OnSpawn()
    {
        // 在角色出厂的时候, 绑定死亡事件
        Dead += Role_Dead;
    }

    public override void UnSpawn()
    {
        //回收的时候, 将脏数据清零
        Dead = null;
        HealthChange = null;

        m_CurrentHP = 0;
        m_MaxHP = 0;
    }
    #endregion

    #region 帮助方法
    #endregion
}
