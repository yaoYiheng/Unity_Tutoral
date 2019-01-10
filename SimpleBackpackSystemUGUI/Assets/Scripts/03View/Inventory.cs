using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {


    private InventoryGrid[] m_Grids;

    private void Awake()
    {
        m_Grids = transform.GetComponentsInChildren<InventoryGrid>();


    }

    /// <summary>
    /// 返回可用的格子.
    /// </summary>
    /// <returns>The avaliable grid.</returns>
    public InventoryGrid GetAvaliableGrid()
    {
        InventoryGrid temp = null;

        foreach (var item in m_Grids)
        {
            if (item.ItemID == 0)
            {
                temp = item;
                break;
            }
        }

        return temp;
    }
}
