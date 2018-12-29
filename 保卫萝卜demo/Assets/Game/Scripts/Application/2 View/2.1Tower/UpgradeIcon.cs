using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeIcon : MonoBehaviour 
{

	SpriteRenderer m_UpgradeIcon;
	Tower m_Tower;

	private void Awake()
	{
		m_UpgradeIcon = GetComponent<SpriteRenderer>();
	}

	public void Load(Tower tower)
	{
		m_Tower = tower;

		WeaponInfo info = Game.Instance.StaticData.GetWeaponInfo(tower.TowerID);
		//根据是否到达顶级设置图片
		string path = "Res/Roles/" + (tower.IsMaxLevel? info.DisableIcon: info.NormalIcon);
		//根据路径获得图片
		m_UpgradeIcon.sprite = Resources.Load<Sprite>(path);
	}
	void OnMouseDown()
	{
		
	}
}