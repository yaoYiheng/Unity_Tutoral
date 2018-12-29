using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePanel : MonoBehaviour
 {
	 UpgradeIcon m_UpgradIcon;
	 SellIcon m_SellIcon;

	 private void Awake()
	 {
		 m_SellIcon = GetComponentInChildren<SellIcon>();
		 m_UpgradIcon = GetComponentInChildren<UpgradeIcon>();
	 }

	public void Show(Tower tower)
	{	
		//根据传入的tower获取到自身控件的位置
		transform.position = tower.transform.position;
		//为其子控件传入所需的参数
		m_SellIcon.Load(tower);
		m_UpgradIcon.Load(tower);

		//设置其可用
		this.gameObject.SetActive(true);
	}

	public void Hide()
	{
		this.transform.gameObject.SetActive(false);
	}

}
