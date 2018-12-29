using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatPanel : MonoBehaviour {

	//持有对与其下的两个子控件的引用
	WeaponIcon[] m_WeaponIcons;

	private void Awake()
	{
		m_WeaponIcons = GetComponentsInChildren<WeaponIcon>();
	}

	//隐藏

	// 显示
	public void Show(GameModel gameModel, Vector3 position, bool isUpside)
	{
		//设置每个子控件的显示
		for (int i = 0; i < m_WeaponIcons.Length; i++)
		{
			//获取武器信息
			WeaponInfo weapon = Game.Instance.StaticData.GetWeaponInfo(i);

			m_WeaponIcons[i].Load(gameModel, position, weapon, isUpside);
		}

		//设置创建面板的位置
		this.transform.position = position;
		//设置创建面板的显示
		this.gameObject.SetActive(true);
	}

	public void Hide()
	{
		this.gameObject.SetActive(false);
	}
}
