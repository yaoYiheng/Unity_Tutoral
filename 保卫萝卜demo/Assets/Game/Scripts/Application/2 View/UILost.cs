using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILost : View
{
    #region 常量
    #endregion

    #region 事件
    #endregion


    #region 字段
    public Text txtCurrent;
    public Text txtTotal;
    #endregion

    #region 属性
    public override string Name
    {
        get
        {
            return Const.V_UILost;
        }
    }
    #endregion

    #region 方法

    public void UpdateRoundInfo(int current, int total)
    {
        txtCurrent.text = current.ToString("D2");
        txtTotal.text = current.ToString();
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
        RoundModel rm = GetModel<RoundModel>();
        UpdateRoundInfo(rm.CurrentRoundInex + 1, rm.TotalRound);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
  

    public void OnRestartClick()
    {
        GameModel game = GetModel<GameModel>();
        // SendEvent(Const.E_StartLevel, new StartLevelArgs(){LevelIndex = game.PlayingLevelIndex});
        StartLevelArgs e = new StartLevelArgs();
        e.LevelIndex = game.PlayingLevelIndex;
        SendEvent(Const.E_StartLevel, e);
    }
    #endregion

    #region Unity回调

    private void Awake()
    {
        UpdateRoundInfo(0, 0);
    }
    #endregion

    #region 事件回调


    //接受到进入场景的事件回调, 就根据事件所传递的参数, 来执行显示该脚本控制的对象的运行
    public override void HandleEvent(string eventName, object data)
    {

    }
    #endregion

    #region 帮助方法
    #endregion


}
