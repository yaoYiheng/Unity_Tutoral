using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    public Weapon(int id, string icon, string name, string des, ItemType type, int sell, int buy, int damage, float range) : base(id, icon, name, des, type, sell, buy)
    {
        base.Type = type;
        this.Damage = damage;
        this.Range = range;
    }

    public Weapon(){}
    public int Damage { get; set; }
    public float Range { get; set; }
    //public Weapon(int id, string icon, string name, string des, int sell, int buy, ItemType type, int damage, float range)
    //    : base(id, icon, name, des, sell, buy)
    //{
    //    base.Type = type;
    //    this.Damage = damage;
    //    this.Range = range;
    //}
}
