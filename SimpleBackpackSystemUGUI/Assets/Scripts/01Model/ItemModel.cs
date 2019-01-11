using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemModel 
{
    private static Dictionary<int, Item> m_Items = new Dictionary<int, Item>();


    public static void AddItem(int itemid)
    {
        if (m_Items.ContainsKey(itemid))
        {
            Delete(itemid);
        }

        Item item = StaticData.Instance.GetItem(itemid);
        m_Items.Add(itemid, item);
    }

    public static Item GetItem(int itemid)
    {
        Item item = new Item();
        m_Items.TryGetValue(itemid, out item);

        return item;
    }

    public static void Delete(int itemid)
    {
        if (m_Items.ContainsKey(itemid))
        {
            m_Items.Remove(itemid);
        }
    }
}