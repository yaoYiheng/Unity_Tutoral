using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeIcon : MonoBehaviour
{
    SpriteRenderer m_UpgradeRender;

    bool m_IsEnough = false;
    Tower m_Tower;
    private void Awake()
    {
        m_UpgradeRender = GetComponent<SpriteRenderer>();
    }
    public void LoadIcon(Tower tower, GameModel gameModel)
    {
        m_IsEnough = gameModel.Gold >= tower.Price;
        m_Tower = tower;
        //设置图片显示
        string path = "Res/Roles/" + (m_IsEnough ? "upgrade_180" : "upgrade180");
        Sprite sprite = Resources.Load<Sprite>(path);
        m_UpgradeRender.sprite = sprite;


    }
    private void OnMouseDown()
    {
        if (!m_IsEnough) return;
        SendMessageUpwards("UpgradeTower", new UpgradeToweArgs() { Tower = m_Tower }, SendMessageOptions.DontRequireReceiver);
    }
}
