using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISelect : View
{


    #region 常量
    #endregion

    #region 事件
    #endregion

    #region 字段
    #endregion

    #region 属性
    public override string Name
    {
        get
        {
            return  Const.V_Select; 
        }
    }
    #endregion




    #region 方法
    public void GoBack()
    {
        Game.Instance.LoadScene(1);
    }
    #endregion
    public void ChooseLevel()
    {
        //添加事件
        //初始化事件参数
        StartLevelArgs args = new StartLevelArgs() { LevelIndex = 0 };

        //向系统发送事件, 和与事件相关的参数.
        SendEvent(Const.E_StartLevel, args);

    }
    #region Unity回调
    #endregion

    #region 事件回调
    public override void HandleEvent(string eventName, object data)
    {
        throw new System.NotImplementedException();
    } 
    #endregion

    #region 帮助方法
    #endregion

}
