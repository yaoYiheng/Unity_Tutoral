using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : ReusableObejct
{

    #region 常量
    #endregion

    #region 事件
    #endregion

    #region 字段
    //动画组件
    Animator m_Animator;
    //当前等级
    int m_Level;
    //目标
    Monster m_Target;
    //计时器
    float m_Timer;
    float m_SmoothTime = 0.5f;
    #endregion

    #region 属性
    public int TowerID { get; private set; }

    public int MaxLevel { get; private set; }

    public float AttackRate { get; private set;}

    public int BasePrice { get; private set; }
    public int Price { get { return BasePrice * Level; } }

    public int AttackArea { get; private set; }

    public int BulletID { get; private set; }

    //格子信息
    public GridInfo GridInfo { get; private set; }
    //地图的边界信息
    public Rect MapRect { get; private set; }

    //设置当前等级
    //并且根据当前等级设置炮塔大小.

    public int Level
    {
        get
        {
            return m_Level;
        }

        set
        {
            m_Level = Mathf.Clamp(value, 0, MaxLevel);

            transform.localScale = Vector3.one * (1 + 0.25f * m_Level);
        }
    }


    #endregion

    #region 方法
    //传入炮塔所需要的数据

    public void LoadData(int towerID, GridInfo gridInfo, Rect mapRect)
    {

        //通过ID获取tower的数据并赋值
        TowerInfo towerInfo = Game.Instance.StaticData.GetTowerInfo(towerID);
        MaxLevel = towerInfo.MaxLevel;
        this.AttackArea = towerInfo.AttackArea;
        this.AttackRate = towerInfo.SpeedRate;
        this.BasePrice = towerInfo.BasePrice;
        this.TowerID = towerID;

        this.MapRect = mapRect;
        this.GridInfo = gridInfo;

        Level = 1;
    }

    public virtual void Attack(Monster monster)
    {
        print(Level);
        //播放攻击动画
        m_Animator.SetTrigger("IsAttack");
        //具体实现交给子类

    }

    void LookAt(Monster monster)
    {
        if (monster == null)
        {
            var vel = 0.0f;
            var eularAngle = transform.eulerAngles;
            eularAngle.z = Mathf.SmoothDamp(eularAngle.z, 0, ref vel, m_SmoothTime, 10f);
            transform.eulerAngles = eularAngle;


        }
        else
        {
            var temp = (monster.Position - this.transform.position).normalized;
            var monstX = temp.x;
            var monstY = temp.y;

            var angle = Mathf.Atan2(monstY, monstX) * Mathf.Rad2Deg;
            var eularAnge = transform.eulerAngles;
            eularAnge.z = angle - 90;
            transform.eulerAngles = eularAnge;

        }
    }
    #endregion

    #region Unity回调

    protected virtual void Awake()
    {
        
    }
    //在这里完成炮塔的怪物的追踪以及攻击
    private void Update()
    {

        // 当目标 不存在时, 对场景的怪物进行查找, 确定目标
        if (m_Target == null)
        {
            //使用Tag对场景存在的怪物进行
            //FindGameObjectsWithTag 会查找场景中所有绑定了个Tag的active状态下的对象
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Monster");
            for (int i = 0; i < gameObjects.Length; i++)
            {
                Monster monster = gameObjects[i].GetComponent<Monster>();
                if (!monster.IsDead && Vector3.Distance(transform.position, monster.Position) <= this.AttackArea) 
                {
                    //找到目标
                    m_Target = monster;
                    break;
                }

            }
        }
        else
        {
            //开始这一帧, 仍要进行判断, 怪物是否死亡或是在攻击范围
            if (m_Target.IsDead  || Vector3.Distance(transform.position, m_Target.Position) > this.AttackArea)
            {
                m_Target = null;
                LookAt(null);
                return;
            }

            //朝向怪物
            LookAt(m_Target);
            //根据间隔发动攻击
            if (Time.time > m_Timer + 1f / this.AttackRate)
            {
                m_Timer = Time.time;
                Attack(m_Target);
            }
        }
    }
    #endregion

    #region 事件回调

    public override void OnSpawn()
    {
        m_Animator = GetComponent<Animator>();
    }

    public override void UnSpawn()
    {
        m_Animator.ResetTrigger("IsAttack");
        m_Animator.Play("Idle");
        transform.eulerAngles = Vector3.zero;
        this.BasePrice = 0;
        this.AttackArea = 0;
        this.AttackRate = 0f;
        this.MaxLevel = 0;

        m_Timer = 0;
        m_Target = null;
        GridInfo = null;

    }
    #endregion

    #region 帮助方法
    #endregion

}
