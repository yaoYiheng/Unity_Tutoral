using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerInfo 
{
    // 塔ID
    public int TowerID;
    public string PrefabName;
    //可以买塔时的图片名称
    public string NormalName;
    //不可买塔时的图片名称
    public string DisableName;
    //攻击速率
    public float SpeedRate;
    //最大等级
    public int MaxLevel;
    //攻击范围
    public int AttackArea;
    // 买入的价格
    public int BasePrice;
    // 使用的子弹的id
    public int BulletID;


}