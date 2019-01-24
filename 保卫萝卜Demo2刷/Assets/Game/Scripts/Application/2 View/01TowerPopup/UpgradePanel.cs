using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePanel : MonoBehaviour
{
    UpgradeIcon m_UpgradeIcon;
    SellIcon m_SellIcon;

    private void Awake()
    {
        m_UpgradeIcon = GetComponentInChildren<UpgradeIcon>();
        m_SellIcon = GetComponentInChildren<SellIcon>();
    }

    public void Show()
    {
        
    }
    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

}
