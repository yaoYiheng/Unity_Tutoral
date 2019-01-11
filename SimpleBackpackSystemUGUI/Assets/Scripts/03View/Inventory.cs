using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : Singleton<Inventory> {


    private InventoryGrid[] m_Grids;

    public bool IsEmpty()
    {

        foreach (var item in m_Grids)
        {
            if (item.ItemID != 0)
            {
                return false;
            }
        }

        return true;
    }

    protected override void Awake()
    {
        base.Awake();
        m_Grids = transform.GetComponentsInChildren<InventoryGrid>();
    }

    /// <summary>
    /// 返回可用的格子.
    /// </summary>
    /// <returns>The avaliable grid.</returns>
    public InventoryGrid GetAvaliableGrid(int itemID)
    {
        InventoryGrid temp = null;

        foreach (var item in m_Grids)
        {
            if(item.ItemID == 0)
            {
                temp = item;
                break;
            }
            //传入的id存在于数组中的话. 说明已经持有
            //添加即可
            if(item.ItemID == itemID)
            {
                temp = item;
                break;

            }
        }

        return temp;
    }
}
