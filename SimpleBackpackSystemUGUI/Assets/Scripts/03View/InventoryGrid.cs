using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class InventoryGrid : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, 
IDragHandler, IEndDragHandler

{

    Text m_CountText;
    int m_ItemID;
    int m_ItemCount;
    bool m_IsOnDrag = false;

    public static Action<int> OnEnter;
    public static Action OnExit;

    #region 属性
    public int ItemCount
    {
        get
        {
            return m_ItemCount;
        }

        set
        {
            m_ItemCount = value;
            if (value == 0)
            {
                m_CountText.gameObject.SetActive(false);

                InventoryItem[] items = GetComponentsInChildren<InventoryItem>();
                foreach (var item in items)
                {
                    Destroy(item.gameObject);
                }
            }
            else
            {
                m_CountText.gameObject.SetActive(true);
                m_CountText.text = value.ToString();
            }
        }
    }

    public int ItemID
    {
        get
        {
            return m_ItemID;
        }

        set
        {
            m_ItemID = value;
            if(value == 0)
            {
                ItemCount = 0;
            }
            else
            {
                ItemCount = 0;
                Item itemInfo = StaticData.Instance.GetItem(value);

                ItemCount = itemInfo.Count;
                GameObject itemGo = Instantiate(Resources.Load<GameObject>("Prefabs/InventoryItem"));
                //GameObject itemGo = Instantiate(itemPrefab);
                //设置格子的父对象
                itemGo.transform.SetParent(this.transform);
                itemGo.transform.localPosition = Vector3.zero;
                itemGo.transform.localScale = Vector3.one;

                InventoryItem item = itemGo.GetComponent<InventoryItem>();

                item.Icon = itemInfo.Icon;
                ItemModel.AddItem(value);

            }


        }
    }

    public bool IsOnDrag
    {
        get
        {
            return m_IsOnDrag;
        }

        set
        {
            m_IsOnDrag = value;
            //当这个图形在被拖拽的时候, 就将其设置为不是射线目标, 所以射线就能够检测这个图形下方的物品
            //当没有被拖拽的时候, 就设置为射线目标.
            TempInventoryItem.Instance.GetComponent<Image>().raycastTarget = !value;
            TempInventoryItem.Instance.gameObject.SetActive(value);

        }
    }
    #endregion
    private void Awake()
    {
        m_CountText = transform.Find("CountText").GetComponent<Text>();
        ItemCount = 0;
        ItemID = 0;
    }


    private void Update()
    {
        if(IsOnDrag)
        {
            Vector2 position;
            Tools.GetMousePosition(out position);
            TempInventoryItem.Instance.SetLocalPosition(position);
        }


    }
    public void UpdateGrid(int itemID, int count = 1)
    {
        m_ItemID = itemID;
        //m_ItemCount += count;
    }
    public void AddItem(int count = 1)
    {
        ItemCount += count;
    }


    #region 事件回调
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerEnter.tag == "Grid")
        {
            if (OnEnter != null)
            {
                OnEnter(ItemID);
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (eventData.pointerEnter == null) return;
        if (eventData.pointerEnter.tag == "Grid")
        {
            if (OnExit != null)
            {
                OnExit();
            }
        }
    }
    //public static Action<PointerEventData> OnDragAction;
    //public static Action OnDropAction;

    public void OnDrag(PointerEventData eventData)
    {
        IsOnDrag = true;
        if (ItemID == 0) return;



        if (eventData.pointerEnter == null)
        {
            return;

        }
        if(eventData.pointerEnter.tag == "Item")
        {

            //获取到拖拽格子下的物品
            Item item = StaticData.Instance.GetItem(ItemID);

            //更新临时的格子
            TempInventoryItem.Instance.Icon = item.Icon;

        }
        else
        {

        }

    }


    public void OnEndDrag(PointerEventData eventData)
    {


        DescribeText.Instance.Hide();
        IsOnDrag = false;

        //不能对一个空格子进行拖拽
        if (ItemID == 0)
        {
            return;
        }//如果拖到外界, 则删除
        else if (eventData.pointerEnter == null)
        {
            ItemID = 0;
            ItemCount = 0;

            ItemModel.Delete(ItemID);


        }//如果拖到的是一个空格子
        else if(eventData.pointerEnter.tag == "Grid")
        {

            InventoryGrid tempGrid = eventData.pointerEnter.transform.GetComponent<InventoryGrid>();
                                              
            if(tempGrid.ItemID == 0)
            {

                //Creat(tempGrid, ItemID);

                tempGrid.ItemID = ItemID;

                ItemID = 0;
                ItemCount = 0;

                ItemModel.Delete(ItemID);


            }

        }
        else if(eventData.pointerEnter.tag == "Item")
        {

            InventoryItem tempItem = eventData.pointerEnter.transform.GetComponent<InventoryItem>();

            InventoryGrid tempGrid = tempItem.transform.parent.GetComponent<InventoryGrid>();

            int tempGridID = tempGrid.ItemID;


            tempGrid.ItemID = this.ItemID;
            this.ItemID = tempGridID;


        }



    }



    #endregion
}
