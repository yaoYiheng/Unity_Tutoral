﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Item
{
    public int Defence { get; private set; }
    public int Power { get; private set; }
    public int Agility { get; private set; }

    public Armor(int id, string icon, string name, string des, int sell, int buy, int defence, int power, int agility)
        : base(id, icon, name, des, sell, buy)
    {

        base.Type = ItemType.Armor;
        this.Defence = defence;
        this.Power = power;
        this.Agility = agility;
    }
}
