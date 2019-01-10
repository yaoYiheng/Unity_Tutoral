using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    private Image m_Icon;

    public string Icon
    {
        set
        {
            string path = "file://" + Consts.IconPath + value;


            m_Icon = GetComponent<Image>();


            StartCoroutine(Tools.LoadImage(path, m_Icon));


        }
    }

    private void Awake()
    {
        

    }
}
