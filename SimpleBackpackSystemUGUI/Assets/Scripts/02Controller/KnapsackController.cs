using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class KnapsackController : MonoBehaviour 
{




    //存储物品
    void StoreItem(int itemId, int count)
    {
        //获取物品数据
        Item itemInfo = StaticData.Instance.GetItem(itemId);
        itemInfo.Count += count;

        //动态加载物品UI
        //GameObject itemPrefab = Resources.Load<GameObject>("Prefabs/InventoryItem");

        //找到可用格子
        InventoryGrid grid = Inventory.Instance.GetAvaliableGrid(itemId);


        //如果找不到可用的格子
        if (grid == null)
        {
            Debug.LogWarning("背包已满");
        }
        else
        {



            if (grid.ItemCount > 0)
            {
                grid.AddItem(count);
            }
            else
            {
                grid.ItemID = itemId;
                grid.UpdateGrid(itemId, count);
                //GameObject itemGo = Instantiate(itemPrefab);
                ////设置格子的父对象
                //itemGo.transform.SetParent(grid.transform);
                //itemGo.transform.localPosition = Vector3.zero;
                //itemGo.transform.localScale = Vector3.one;

                //InventoryItem item = itemGo.GetComponent<InventoryItem>();

                //item.Icon = itemInfo.Icon;
            }


        }

        //将添加的物品保存到数据中.
        //ItemModel.AddItem(itemId);

    }

    private void Update()
    {
        CreatItemRandomly();


        Vector2 position;
        Tools.GetMousePosition(out position);
        DescribeText.Instance.SetLocalPosition(position);


    }

    void CreatItemRandomly()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //产生随机数
            int random = Random.Range(2016, 2023);
            StoreItem(random, 1);
        }
    }

    private void Awake()
    {
        InventoryGrid.OnEnter += InventoryGrid_OnEnter1;
        InventoryGrid.OnExit += InventoryGrid_OnExit;






    }

    void InventoryGrid_OnDragAction(int obj)
    {
        
    }

    void InventoryGrid_OnDropAction()
    {
        
    }


    void InventoryGrid_OnEnter1(int obj)
    {

        if (obj == 0) return;
        //通过id获取到物品
        Item item = StaticData.Instance.GetItem(obj);
        if (item == null) return;


        DescribeText.Instance.Show();

        DescribeText.Instance.UpdateText(GetDescribeText(item));
    }




    void InventoryGrid_OnExit()
    {

        DescribeText.Instance.Hide();
    }


    string GetDescribeText(Item item)
    {
        if (item == null)
            return "";
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<color=red>{0}</color>\n\n", item.Name);
        switch (item.Type)
        {
            case ItemType.Armor:
                Armor armor = item as Armor;
                sb.AppendFormat("力量:{0}\n防御:{1}\n敏捷:{2}\n\n", armor.Power, armor.Defence, armor.Agility);
                break;
            case ItemType.Drag:
                Drag consumable = item as Drag;
                sb.AppendFormat("HP:{0}\nMP:{1}\n\n", consumable.ManaPoint, consumable.HealthPoint);
                break;
            case ItemType.Weapon:
                Weapon weapon = item as Weapon;
                sb.AppendFormat("攻击:{0}\n\n", weapon.Damage);
                break;
            default:
                break;
        }
        sb.AppendFormat("<size=140><color=white>数量：{0}</color></size>\n\n", item.Count);
        sb.AppendFormat("<size=140><color=white>购买价格：{0}\n出售价格：{1}</color></size>\n\n<color=yellow><size=120>描述：{2}</size></color>", item.BuyPrice, item.SellPrice, item.Descrition);
        return sb.ToString();
    }
}
