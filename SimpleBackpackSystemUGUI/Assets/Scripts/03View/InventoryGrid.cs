using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryGrid: MonoBehaviour {

    Text m_CountText;
    int m_ItemID;
    int m_ItemCount;


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
        }
    }

    private void Awake()
    {
        m_CountText = transform.Find("CountText").GetComponent<Text>();
        ItemCount = 0;
        ItemID = 0;
    }

    public void UpdateGrid(int itemID, int count)
    {
        ItemID = itemID;
        ItemCount += count;
    }
    public void AddItem(int count = 1)
    {
        ItemCount += count;
    }
}
