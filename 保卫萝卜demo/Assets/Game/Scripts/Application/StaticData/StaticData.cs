using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : Singleton<StaticData> 
{

    //装备信息, 基本信息不变的属性
    Dictionary<int, MonsterInfo> m_Monsters = new Dictionary<int, MonsterInfo>();

    protected override void Awake()
    {
        base.Awake();

        InitMosterInfo();
    }
    void InitMosterInfo()
    {
        m_Monsters.Add(0, new MonsterInfo(){HealthPoint = 1, MoveSpeed = 1.5f});
        m_Monsters.Add(1, new MonsterInfo(){HealthPoint = 1, MoveSpeed = 1.5f});
        m_Monsters.Add(2, new MonsterInfo(){HealthPoint = 2, MoveSpeed = 1f});
        m_Monsters.Add(3, new MonsterInfo(){HealthPoint = 2, MoveSpeed = 1f});
        m_Monsters.Add(4, new MonsterInfo(){HealthPoint = 3, MoveSpeed = 1f});
        m_Monsters.Add(5, new MonsterInfo(){HealthPoint = 5, MoveSpeed = 0.5f});
    }
}
