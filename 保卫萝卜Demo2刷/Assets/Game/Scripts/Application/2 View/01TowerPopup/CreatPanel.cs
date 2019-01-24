using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 控制整个面板的显示与否, 以及显示位置
/// 对其子控件进行赋值
/// </summary>
public class CreatPanel : MonoBehaviour 
{
    WeaponIcon[] m_WeaponIcons;


    //获取引用
    private void Awake()
    {
        m_WeaponIcons = GetComponentsInChildren<WeaponIcon>();
    }

    //显示整个面板并赋值
    public void Show(GameModel gameModel, Vector3 position, bool isUpside)
    {
        //更新面板位置
        this.transform.position = position;

        // 设置显示
        this.gameObject.SetActive(true);

        // 变量子控件赋值
        for (int i = 0; i < m_WeaponIcons.Length; i++)
        {
            TowerInfo towerInfo = Game.Instance.StaticData.GetTowerInfo(i);

            m_WeaponIcons[i].LoadIcon(gameModel, towerInfo, position, isUpside);

        }
    }

    //隐藏面板
    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
