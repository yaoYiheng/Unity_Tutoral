using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBoard : View
{


    #region 常量
    #endregion

    #region 事件
    #endregion

    #region 字段
    public Text txtScore;
    public Image imgRoundInfo;
    public Text txtCurrent;
    public Text txtTotal;
    public Image PauseInfo;
    public Button BtnSpeed1;
    public Button BtnSpeed2;
    public Button BtnPause;
    public Button BtnResume;
    public Button BtnSystem;


    bool m_IsPlaying = false;
    GameSpeed m_Speed = GameSpeed.One;
    int m_Score = 0;
    #endregion

    #region 属性
    public override string Name
    {
        get
        {
            return Const.V_UIBoard;
        }
    }

    public bool IsPlaying
    {
        get
        {
            return m_IsPlaying;
        }

        set
        {
            m_IsPlaying = value;
            this.BtnPause.gameObject.SetActive(!value);
            this.BtnResume.gameObject.SetActive(value);
            //控制回合与暂停的显示

            this.PauseInfo.gameObject.SetActive(!value);
            this.imgRoundInfo.gameObject.SetActive(value);
        }
    }



    public GameSpeed Speed
    {
        get
        {
            return m_Speed;
        }

        set
        {
            m_Speed = value;
            this.BtnSpeed1.gameObject.SetActive(value == GameSpeed.One);
            this.BtnSpeed2.gameObject.SetActive(value == GameSpeed.Two);
        }
    }

    public int Score
    {
        get
        {
            return m_Score;
        }

        set
        {
            m_Score = value;
            txtScore.text = value.ToString();
        }
    }



    #endregion

    #region 方法

    public void OnSpeed1Click()
    {
        Speed = GameSpeed.Two;
    }
    public void OnSpeed2Click()
    {
        Speed = GameSpeed.One;
    }
    public void OnPauseClick()
    {
        IsPlaying = true;
    }
    public void OnResumeClick()
    {
        IsPlaying = false;
    }
    public void OnSystemClick()
    {
        
    }
    public void UpdateRoundInfo(int current, int total)
    {
        txtCurrent.text = current.ToString("D2");//始终保留2位整数
        txtTotal.text = total.ToString();
    }
    #endregion

    #region Unity回调

    private void Awake()
    {
        IsPlaying = true;
        Score = 0;
        Speed = GameSpeed.One;
    }
    #endregion

    #region 事件回调

    public override void HandleEvent(string eventName, object data)
    {

    }
    #endregion

    #region 帮助方法
    #endregion


}