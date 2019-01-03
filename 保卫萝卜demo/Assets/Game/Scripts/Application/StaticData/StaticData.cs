using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : Singleton<StaticData> 
{

    public const float MONSTER_SPEED_ONE = 1f;
    public const float MONSTER_SPEED_TWO = 5.0f;
    public const float MONSTER_SPEED_THREE = 5.0f;
    //装备信息, 基本信息不变的属性
    Dictionary<int, MonsterInfo> m_Monsters = new Dictionary<int, MonsterInfo>();
    Dictionary<int, LuoboInfo> m_Luobos = new Dictionary<int, LuoboInfo>();
    Dictionary<int, WeaponInfo> m_Weapons = new Dictionary<int, WeaponInfo>();

    Dictionary<int, BulletInfo> m_Bullet = new Dictionary<int, BulletInfo>();

    protected override void Awake()
    {
        base.Awake();

        InitMosterInfo();

        InitLuoBo();

        InitWeapons();

        InitBullets();
    }

    void InitBullets()
    {
        m_Bullet.Add(0, new BulletInfo(){BulletID = 0, PrefabName = "BallBullet", BaseSpeed = 5.0f, BaseAttack = 3});
        m_Bullet.Add(1, new BulletInfo(){BulletID = 1, PrefabName = "FanBullet", BaseSpeed = 0.5f, BaseAttack = 3});
    }
    void InitWeapons()
    {
        m_Weapons.Add(0, new WeaponInfo(){WeaponID = 0, PrefabName = "Bottle", BasePrice = 1, NormalIcon = "Bottle/Bottle01", DisableIcon = "Bottle/Bottle00", MaxLevel = 3, AttactArea = 3.0f, FireRate = 1, BulletID = 0});
        m_Weapons.Add(1, new WeaponInfo(){WeaponID = 1, PrefabName = "Fan",    BasePrice = 1, NormalIcon = "Fan/Fan01",       DisableIcon = "Fan/Fan00",       MaxLevel = 3, AttactArea = 3.0f, FireRate = 0.4f, BulletID = 1});
    }
    void InitLuoBo()
    {
        m_Luobos.Add(0, new LuoboInfo(){LuoboID = 0, HealthPoint = 4});
    }
        void InitMosterInfo()
    {
        m_Monsters.Add(0, new MonsterInfo(){MonsterID = 0, HealthPoint = 1, MoveSpeed = MONSTER_SPEED_ONE});
        m_Monsters.Add(1, new MonsterInfo(){MonsterID = 1, HealthPoint = 11, MoveSpeed = MONSTER_SPEED_ONE});
        m_Monsters.Add(2, new MonsterInfo(){MonsterID = 2, HealthPoint = 12, MoveSpeed = MONSTER_SPEED_ONE});
        m_Monsters.Add(3, new MonsterInfo(){MonsterID = 3, HealthPoint = 12, MoveSpeed = MONSTER_SPEED_ONE});
        m_Monsters.Add(4, new MonsterInfo(){MonsterID = 4, HealthPoint = 13, MoveSpeed = MONSTER_SPEED_ONE});
        m_Monsters.Add(5, new MonsterInfo(){MonsterID = 5, HealthPoint = 15, MoveSpeed = MONSTER_SPEED_ONE});
    }

    public BulletInfo GetBulletInfo(int BulletInfoID)
    {
        return m_Bullet[BulletInfoID];
    }

    public WeaponInfo GetWeaponInfo(int WeaponID)
    {
        return m_Weapons[WeaponID];
    }
    public MonsterInfo GetMonsterInfo(int MonsterID)
    {
        return m_Monsters[MonsterID];
    }
    
    public LuoboInfo GetLuoBoInfo()
    {
        return m_Luobos[0];
    }
}
