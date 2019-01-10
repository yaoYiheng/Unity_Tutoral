using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnapsackController : MonoBehaviour 
{

    //存储物品
    void StoreItem(int itemId, int count)
    {
        //获取物品数据
        Item itemInfo = StaticData.Instance.GetWeapon(itemId);

        //动态加载物品UI
        GameObject itemPrefab = Resources.Load<GameObject>("Prefabs/InventoryItem");

        //找到可用格子
        InventoryGrid grid = Inventory.GetAvaliableGrid(itemId);

        //如果找不到可用的格子
        if (grid == null)
        {
            Debug.LogWarning("背包已满");
        }
        else
        {



            if (grid.ItemCount > 1)
            {
                grid.AddItem(count);
            }
            else
            {
                grid.UpdateGrid(itemId, count);
                GameObject itemGo = Instantiate(itemPrefab);
                //设置格子的父对象
                itemGo.transform.SetParent(grid.transform);
                itemGo.transform.localPosition = Vector3.zero;
                itemGo.transform.localScale = Vector3.one;

                InventoryItem item = itemGo.GetComponent<InventoryItem>();

                item.Icon = itemInfo.Icon;
            }


        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //产生随机数
           int random = Random.Range(2016, 2023);
            StoreItem(random, 1);
        }
    }

}
