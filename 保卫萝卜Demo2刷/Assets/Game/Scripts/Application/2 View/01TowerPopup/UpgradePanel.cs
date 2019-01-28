using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePanel : MonoBehaviour
{
    UpgradeIcon m_UpgradeIcon;
    SellIcon m_SellIcon;
    Tower m_Tower;
    private void Awake()
    {
        m_UpgradeIcon = GetComponentInChildren<UpgradeIcon>();
        m_SellIcon = GetComponentInChildren<SellIcon>();
    }

    public void Show(UpgradePanelArgs upgradePanelArgs, GameModel gameModel)
    {

        transform.position = upgradePanelArgs.Position;

        m_Tower = upgradePanelArgs.Tower;

        if (!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }

        m_UpgradeIcon.LoadIcon(m_Tower, gameModel);
        m_SellIcon.LoadData(m_Tower);
    }
    public void Hide()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
    }

}
