using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    public int Damage { get; private set; }
    public float Range { get; private set; }
    public Weapon(int id, string icon, string name, string des, int sell, int buy, int damage, float range)
        : base(id, icon, name, des, sell, buy)
    {
        base.Type = ItemType.Weapon;
        this.Damage = damage;
        this.Range = range;
    }
}
