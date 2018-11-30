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

    public void ChooseLevel()
    {

        //添加事件
        //初始化事件参数
        StartLevelArgs args = new StartLevelArgs() { LevelIndex = 0 };

        //向系统发送事件, 和与事件相关的参数.
        SendEvent(Const.E_StartLevel, args);

    }

    //加载卡片
    public void LoadCards()
    {
        print("----------Loads");
    }
    #endregion

    #region Unity回调
    #endregion

    #region 事件回调

    public override void RegisterEvent()
    {
        this.AttentionEvents.Add(Const.E_EnterScene);
    }
    public override void HandleEvent(string eventName, object data)
    {
        SceneArgs args = data as SceneArgs;
        switch(args.Level)
        {
            case 2:
                LoadCards();
                break;
        }
    } 
    #endregion

    #region 帮助方法
    #endregion

}
