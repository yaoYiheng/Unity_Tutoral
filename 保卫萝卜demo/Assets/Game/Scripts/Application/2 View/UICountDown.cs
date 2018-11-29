using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICountDown : View
{


    #region 常量
    #endregion

    #region 事件
    #endregion

    #region 字段
    #endregion

    #region 属性
    public Image imgCount;
    public Sprite[] Sprites;

    public override string Name
    {
        get
        {
            return Const.V_UICountDown;
        }
    }
    #endregion

    #region 方法
    #endregion

    #region Unity回调
    #endregion

    #region 事件回调
    public override void HandleEvent(string eventName, object data)
    {
        switch(eventName)
        {
            case Const.E_EnterScene:
                SceneArgs args = data as SceneArgs;

                if(args.Level == 3)
                {
                    
                }
                break;
        }
    }
    #endregion

    #region 帮助方法
    #endregion



}