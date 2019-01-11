using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public int ItemID { get;  set; }  //物品ID
    public string Icon { get;  set; } //icon
    public string Name { get;  set; } // 物品名称
    public string Descrition { get;  set; } //描述
    public int SellPrice { get;  set; }
    public int BuyPrice { get;  set; }
    public ItemType Type { get; set; }

    public int Count { get; set; }

    public Item(){}
    public Item(int id, string icon, string name, string des,ItemType type, int sell, int buy)
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