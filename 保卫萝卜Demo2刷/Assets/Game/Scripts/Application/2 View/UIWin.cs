using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIWin : View
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
            return Consts.V_Win;
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

        RoundModel round = GetModel<RoundModel>();
        UpdateRoundInfo(round.CurrentRoundIndex, round.TotalRounds);

    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

    public void OnContinueClick()
    {
        GameModel game = GetModel<GameModel>();
        if (game.CurrentPlayingIndex >= game.AllLevelsCount - 1)
        {
            //打通最后一关
            Game.Instance.LoadScene(4);
        }
        else
        {
            SendEvent(Consts.E_StartLevel, new StarLevelArgs() { LevelCardIndex = game.CurrentPlayingIndex + 1 });
        }
    }

    public void OnRestartClick()
    {
        GameModel game = GetModel<GameModel>();

        SendEvent(Consts.E_StartLevel, new StarLevelArgs() { LevelCardIndex = game.CurrentPlayingIndex });
    }
    #endregion

    #region Unity回调
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
