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
    public Sprite[] NumberSprite;
    private Image m_Count;
    #endregion

    #region 属性
    public override string Name
    {
        get
        {
            return Consts.V_CountDown;
        }
    }
    #endregion

    #region 方法

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void StartCountDown()
    {
        StartCoroutine(StartCD());
    }

    IEnumerator StartCD()
    {
        int count = 3;
        while (count > 0)
        {

            m_Count.sprite = NumberSprite[count - 1];
            yield return new WaitForSeconds(1f);

            count--;

            if (count <= 0) break;
        }

        //隐藏倒计时页面
        this.Hide();
        //发布倒计时完成事件.


    }
    #endregion

    #region Unity回调
    private void Awake()
    {
        m_Count = transform.Find("Count").GetComponent<Image>();

    }
    #endregion

    #region 事件回调

    public override void AddEventToList()
    {
        AttentionEventList.Add(Consts.E_EnterScene);
    }
    public override void HandleEvent(string eventName, object data = null)
    {
        switch (eventName)
        {
            case Consts.E_EnterScene:
                SceneIndexArgs args = data as SceneIndexArgs;
                print(args.SceneIndex);
                if (args.SceneIndex == 3)
                {
                    StartCountDown();
                }
                break;
            default:
                break;
        }
    }
    #endregion

    #region 帮助方法
    #endregion



}
