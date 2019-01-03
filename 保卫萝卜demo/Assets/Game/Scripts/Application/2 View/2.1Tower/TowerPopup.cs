using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPopup : View 
{


	#region 常量

	#endregion

	#region 事件

	#endregion

	#region 字段
	private static TowerPopup m_Instance;

	public static TowerPopup Instance
	{
		get{return m_Instance;}
	}
	public CreatPanel m_CreatPanel;
	public UpgradePanel m_UpgradePanel;
	#endregion

	#region 属性
	    public override string Name
    {
        get
        {
            return Const.V_TowerPopup;
        }
    }

	public bool IsShow
	{
		get
		{
			foreach (Transform item in transform)
			{	
				if(item.gameObject.activeSelf)
				{
					return true;
				}
	
			}
			return false;
		}
	}
	#endregion

	#region 方法
	//显示创建炮塔
	public void ShowCreatPanel(ShowCreatPanelArgs args)
	{
		HideAll();
		GameModel game = GetModel<GameModel>();

		m_CreatPanel.Show(game, args.Position, args.IsUpside);

	}

	//显示升级炮塔
	public void ShowUpgradPanel(ShowUpgradePanelArgs args)
	{
		HideAll();
		m_UpgradePanel.Show(args.Tower);
	}
	//隐藏以上两个面板
	public void HideAll()
	{
		m_CreatPanel.Hide();
		m_UpgradePanel.Hide();
	}

	//当点击了WeaponIcon后会调用该方法, 发布创建武器的事件
	void SpawnWeapon(SpawnWeaponArgs args)
	{
		//接收到来自其子控件的点击以及传递来的参数, 并且向MVC发送事件
		SendEvent(Const.E_SpawnWeapon, args);

	}
	
	void UpgradeWeapon()
	{

	}

	void SellWeapon()
	{

	}
	#endregion

	#region Unity回调
	void Awake()
	{
		m_Instance = this;
	}
	#endregion

	#region 事件回调
	public override void RegisterEvent()
	{
		this.AttentionEvents.Add(Const.E_ShowCreatPanel);
		this.AttentionEvents.Add(Const.E_ShowUpgradePanel);
		this.AttentionEvents.Add(Const.E_HideAllPanel);
	}
	
	public override void HandleEvent(string eventName, object data)
	{
		switch (eventName)
		{
			case Const.E_ShowCreatPanel:
			ShowCreatPanelArgs args = data as ShowCreatPanelArgs;
			ShowCreatPanel(args);
			break;

			case Const.E_ShowUpgradePanel:
			ShowUpgradePanelArgs arg = data as ShowUpgradePanelArgs;
			ShowUpgradPanel(arg);
			break;
			
			case Const.E_HideAllPanel:
			HideAll();
			break;
		}
	}

	#endregion

	#region 帮助方法

	#endregion
}