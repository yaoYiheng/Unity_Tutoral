using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    private Image m_IconName;

    public string IconName
    {
        set
        {
            string path = "file://" + Consts.IconPath + value;
            StartCoroutine(Tools.LoadImage(path, m_IconName));

        }
    }

    private void Awake()
    {
        m_IconName = GetComponent<Image>();

    }
}
