using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public int ItemID { get; private set; }  //物品ID
    public string Icon { get; private set; } //icon
    public string Name { get; private set; } // 物品名称
    public string Descrition { get; private set; } //描述
    public int SellPrice { get; private set; }
    public int BuyPrice { get; private set; }
    public ItemType Type { get; protected set; }

    public Item(int id, string icon, string name, string des, int sell, int buy)
    {
        this.ItemID = id;
        this.Icon = icon;
        this.Name = name;
        this.Descrition = des;
        this.SellPrice = sell;
        this.BuyPrice = buy;
    }
}

public enum ItemType
{
    Weapon,
    Drag,
    Armor
}