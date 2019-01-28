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
    public CreatPanel CreatPanel;
    public UpgradePanel UpgradePanel;
    #endregion

    #region 属性
    public static TowerPopup Instance
    {
        get { return m_Instance; }
    }
    public override string Name
    {
        get
        {
            return Consts.V_TowerPopup;
        }
    }
    #endregion

    #region 方法
    public void HideAllPanels()
    {
        CreatPanel.Hide();
        UpgradePanel.Hide();
    }
    public bool IsPanelShow()
    {
        foreach (var item in transform)
        {
            if ((item as Transform).gameObject.activeSelf)
            {
                return true;

            }
            
        }
        return false;
    }

    public void ShowCreatPanel(CreatPanelArgs creatPanelArgs)
    {
        Vector3 position = creatPanelArgs.Position;
        bool isUpside = creatPanelArgs.IsUpside;

        GameModel gameModel = GetModel<GameModel>();
        CreatPanel.Show(gameModel, position, isUpside);
    }

    void SpawnerTower(SpawnTowerArgs spawnTowerArgs)
    {

        SendEvent(Consts.E_SpawnTower, spawnTowerArgs);

    }

    void ShowUpgradePanel(UpgradePanelArgs upgradePanelArgs)
    {
        GameModel gameModel = GetModel<GameModel>();
        UpgradePanel.Show(upgradePanelArgs, gameModel);
    }

    void UpgradeTower(UpgradeToweArgs upgradeToweArgs)
    {

        SendEvent(Consts.E_UpgradeTower, upgradeToweArgs);
    }

    void SellTower(SellTowerArgs sellTowerArgs)
    {
        SendEvent(Consts.E_SellTower, sellTowerArgs);
    }
    #endregion

    #region Unity回调
    private void Awake()
    {
        m_Instance = this;
        HideAllPanels();
    }
    #endregion

    #region 事件回调
    public override void AddEventToList()
    {
        AttentionEventList.Add(Consts.E_ShowCreatPanel);
        AttentionEventList.Add(Consts.E_ShowUpgradePanel);
        AttentionEventList.Add(Consts.E_HideAllPanels);
    }

    public override void HandleEvent(string eventName, object data = null)
    {
        switch (eventName)
        {
            case Consts.E_ShowCreatPanel:
                CreatPanelArgs creatPanelArgs = data as CreatPanelArgs;
                ShowCreatPanel(creatPanelArgs);

                break;
            case Consts.E_ShowUpgradePanel:
                UpgradePanelArgs upgradePanelArgs = data as UpgradePanelArgs;
                ShowUpgradePanel(upgradePanelArgs);
                break;
            case Consts.E_HideAllPanels:
                HideAllPanels();
                break;
            default:
                break;
        }
    }
    #endregion

    #region 帮助方法
    #endregion



}