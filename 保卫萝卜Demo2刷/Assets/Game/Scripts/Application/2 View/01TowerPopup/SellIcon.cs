using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellIcon : MonoBehaviour
{
    Tower m_Tower;
    public void LoadData(Tower tower)
    {
        m_Tower = tower;
    }

    private void OnMouseDown()
    {
        SendMessageUpwards("SellTower", new SellTowerArgs() { Tower = m_Tower });
    }

}
