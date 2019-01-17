using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luobo : Role
{

    private Animator m_Animator;


    public override void OnDamage(int amount)
    {
        if (!IsDead )
        {
            m_Animator.SetTrigger("IsDamage");
        }
        base.OnDamage(amount);
    }

    public override void Role_Dead(Role obj)
    {
        base.Role_Dead(obj);
        m_Animator.SetBool("IsDead", true);



    }

    public override void OnSpawn()
    {
        base.OnSpawn();


        //进行出厂时的设置
        m_Animator = GetComponent<Animator>();
        m_Animator.Play("Luobo_Idle");
        // 获取游戏数据进行赋值
        LuoboInfo info = StaticData.Instance.GetLuoboInfo();
        this.MaxHP = info.HealthPoint;
        this.CurrentHP = info.HealthPoint;

    }



    public override void UnSpawn()
    {
        base.UnSpawn();

        m_Animator.SetBool("IsDead", false);
        m_Animator.ResetTrigger("IsDamage");

        this.MaxHP = 0;
        this.CurrentHP = 0;
    }
}
