using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : ReusableObejct
{


    #region 常量
    #endregion

    #region 事件
    #endregion

    #region 字段
    Animator m_Animator;
    int m_Level;
    #endregion

    #region 属性
    public int BulletID { get; set; }
    public int Level 
    { 
        get { return m_Level; }  

        set{
            m_Level = value;
            transform.localScale = Vector3.one * (1 + 0.25f * m_Level);} }
    public int BaseSpeed { get; private set; }
    public int BaseAttackPoint { get; private set; }

    //移动速度
    public int Speed{ get { return BaseSpeed * Level; }}
    public int AttackPoint{ get { return BaseAttackPoint * Level; }}

    public Rect MapRect { get; set; }

    public float DelayDestoryWait = 0.1f;
    //子弹是否爆炸
    protected bool m_IsExploded;



    #endregion

    #region 方法
    //..加载数据
    public void LoadData(int bulletId, int towerLevel, Rect mapRect)
    {
        Level = towerLevel;
        MapRect = mapRect;
        BulletID = bulletId;

        BulletInfo bulletInfo = Game.Instance.StaticData.GetBulletInfo(bulletId);
        this.BaseSpeed = bulletInfo.BaseSpeed;
        this.BaseAttackPoint = bulletInfo.AttackPoint;
    }

    //爆炸
    public virtual void Explode()
    {
        m_IsExploded = true;
        //播放爆炸动画
        m_Animator.SetTrigger("IsExplode");

        //延迟回收
        StartCoroutine(DelayDestory());
    }

    IEnumerator DelayDestory()
    {
        yield return new WaitForSeconds(DelayDestoryWait);
        Game.Instance.ObjectPool.UnSpawn(this.gameObject);
    }
    #endregion

    #region Unity回调
    protected virtual void Awake()
    {
        m_Animator = GetComponent<Animator>();
        m_Animator.Play("Play");

    }
    protected virtual void Update()
    {
        
    }

    #endregion

    #region 事件回调
    public override void OnSpawn()
    {

    }

    public override void UnSpawn()
    {
        m_IsExploded = false;
        m_Animator.Play("Play");
        m_Animator.SetTrigger("IsExplode");
    }
    #endregion

    #region 帮助方法
    #endregion
}
