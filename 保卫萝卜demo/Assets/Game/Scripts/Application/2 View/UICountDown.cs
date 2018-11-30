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

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
    public void StartCountDown()
    {
        Show();
        //显示倒计时

        StartCoroutine(DisplayCountDound());
    }
    IEnumerator DisplayCountDound()
    {
        int count = Sprites.Length;
        while(count > 0)
        {
            imgCount.sprite = Sprites[count - 1];
            count--;
            yield return new WaitForSeconds(1);

            if (count <= 0) break;
        }
        Hide();

        //发布倒计时结束的事件
        SendEvent(Const.E_CountDownComplete);
    }
    #endregion

    #region Unity回调
    #endregion

    #region 事件回调
    public override void RegisterEvent()
    {
        this.AttentionEvents.Add(Const.E_EnterScene);
    }
    //接受到进入场景的事件回调, 就根据事件所传递的参数, 来执行显示该脚本控制的对象的运行
    public override void HandleEvent(string eventName, object data)
    {
        switch(eventName)
        {
            case Const.E_EnterScene:
                SceneArgs args = data as SceneArgs;

                if(args.Level == 3)
                {
                    StartCountDown();
                }
                break;
        }
    }
    #endregion

    #region 帮助方法
    #endregion



}