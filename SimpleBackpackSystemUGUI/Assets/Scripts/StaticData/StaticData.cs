using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData : Singleton<StaticData> 
{
    //Dictionary<int, Weapon> m_Weapons = new Dictionary<int, Weapon>();
    //Dictionary<int, Drag> m_Drags = new Dictionary<int, Drag>();
    //Dictionary<int, Armor> m_Armors = new Dictionary<int, Armor>();

    Dictionary<int, Item> m_Items = new Dictionary<int, Item>();


    protected override void Awake()
    {
        base.Awake();
        InitWeapon();
    }


    void InitWeapon()
    {
        m_Items.Add(2016, new Weapon() { ItemID = 2016, Icon = "rod-icon.png", Name = "火柴棍", Descrition = "这是一根小火柴", Type = ItemType.Weapon, SellPrice = 100, BuyPrice = 80, Damage = 10, Range = 3.0f });
        m_Items.Add(2017, new Weapon() { ItemID = 2017, Icon = "rod-icon02.png", Name = "金属棍", Descrition = "金属棍, 打断你的狗腿信不信", Type = ItemType.Weapon, SellPrice = 100, BuyPrice = 80, Damage = 10, Range = 3.0f });
        m_Items.Add(2018, new Weapon() { ItemID = 2018, Icon = "rod-icon03.png", Name = "神级魔法棒", Descrition = "哈利波特的棍子", Type = ItemType.Weapon, SellPrice = 100, BuyPrice = 80, Damage = 10, Range = 3.0f });
        m_Items.Add(2019, new Weapon() { ItemID = 2019, Icon = "sword0-icon.png", Name = "木剑", Descrition = "等你的水平到了独孤求败的程度才配的上这把剑", Type = ItemType.Weapon, SellPrice = 100, BuyPrice = 80, Damage = 10, Range = 3.0f });
        m_Items.Add(2020, new Weapon() { ItemID = 2020, Icon = "sword0-icon00.png", Name = "双剑", Descrition = "双剑合璧? 你的小龙女呢? 对! 就是你的左手", Type = ItemType.Weapon, SellPrice = 100, BuyPrice = 80, Damage = 10, Range = 3.0f });
        m_Items.Add(2021, new Weapon() { ItemID = 2021, Icon = "sword1-icon.png", Name = "黄金剑", Descrition = "就问你拿不拿的动呵呵? 出门分分钟被抢", Type = ItemType.Weapon, SellPrice = 100, BuyPrice = 80, Damage = 10, Range = 3.0f });
        m_Items.Add(2022, new Weapon() { ItemID = 2022, Icon = "sword2-icon.png", Name = "神级圣剑", Descrition = "大伯嗑药, GodLike", Type = ItemType.Weapon, SellPrice = 100, BuyPrice = 80, Damage = 10, Range = 3.0f });

    }

    public Item GetItem(int id)
    {
        return m_Items[id];
    }
}
