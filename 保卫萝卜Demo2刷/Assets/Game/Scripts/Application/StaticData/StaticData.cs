﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : Singleton<StaticData>
{
    Dictionary<int, MonsterInfo> m_Monsters = new Dictionary<int, MonsterInfo>();
    Dictionary<int, LuoboInfo> m_Luobo = new Dictionary<int, LuoboInfo>();
    Dictionary<int, TowerInfo> m_Towers = new Dictionary<int, TowerInfo>();
    Dictionary<int, BulletInfo> m_Bullets = new Dictionary<int, BulletInfo>();

    protected override void Awake()
    {
        base.Awake();
        InitMonsters();
        InitLuobo();
        InitTower();
        initBullet();
    }

    void InitTower()
    {
        m_Towers.Add(0, new TowerInfo() { TowerID = 0, PrefabName = "Bottle", NormalName = "Bottle/Bottle01", DisableName = "Bottle/Bottle00", AttackArea = 4, SpeedRate = 1.0f, BasePrice = 80, MaxLevel = 3, BulletID = 0 });
        m_Towers.Add(1, new TowerInfo() { TowerID = 1, PrefabName = "Fan",    NormalName = "Fan/Fan01",       DisableName = "Fan/Fan00",       AttackArea = 4, SpeedRate = .5f, BasePrice = 80, MaxLevel = 3, BulletID = 1 });
    }

    void initBullet()
    {
        m_Bullets.Add(0, new BulletInfo() { BulletID = 0, PrefabName = "BallBullet", AttackPoint = 1, BaseSpeed = 4 });
        m_Bullets.Add(1, new BulletInfo() { BulletID = 1, PrefabName = "FanBullet", AttackPoint = 1, BaseSpeed = 2});
    }

    void InitMonsters()
    {
        m_Monsters.Add(0, new MonsterInfo() { MonsterID = 0, HealthPoint = 3, MoveSpeed = 3, Gold = 30 });
        m_Monsters.Add(1, new MonsterInfo() { MonsterID = 1, HealthPoint = 1, MoveSpeed = 1, Gold = 30 });
        m_Monsters.Add(2, new MonsterInfo() { MonsterID = 2, HealthPoint = 1, MoveSpeed = 1, Gold = 30 });
        m_Monsters.Add(3, new MonsterInfo() { MonsterID = 3, HealthPoint = 1, MoveSpeed = 1, Gold = 30 });
        m_Monsters.Add(4, new MonsterInfo() { MonsterID = 4, HealthPoint = 1, MoveSpeed = 1, Gold = 30 });
        m_Monsters.Add(5, new MonsterInfo() { MonsterID = 5, HealthPoint = 1, MoveSpeed = 1, Gold = 30 });
        m_Monsters.Add(6, new MonsterInfo() { MonsterID = 6, HealthPoint = 1, MoveSpeed = 1, Gold = 30 });
    

    }

    void InitLuobo()
    {
        m_Luobo.Add(0, new LuoboInfo() { LuoboID = 0, HealthPoint = 2 });
    }


    public LuoboInfo GetLuoboInfo()
    {
        return m_Luobo[0];
    }
    public MonsterInfo GetMonsterInfo(int monsterId)
    {
        return m_Monsters[monsterId];
    }

    public TowerInfo GetTowerInfo(int towerID)
    {
        return m_Towers[towerID];
    }

    public BulletInfo GetBulletInfo(int bulletid)
    {
        return m_Bullets[bulletid];
    }
}
