﻿using System.Collections;
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

    private Text m_GoldText;
    private Text m_CurrentText;
    private Text m_TotalText;
    private Image m_RoundInfo;
    private Image m_PauseImage;

    private Button m_ButtonSpeed1;
    private Button m_ButtonSpeed2;
    private Button m_ButtonPause;
    private Button m_ButtonContinue;


    private bool m_IsPlaying = false;

    private int m_Gold = 0;
    private GameSpeed m_GameSpeed;
    #endregion

    #region 属性

    public override string Name
    {
        get
        {
            return Consts.V_Board;
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
            m_ButtonPause.gameObject.SetActive(!value);
            m_PauseImage.gameObject.SetActive(!value);

            m_ButtonContinue.gameObject.SetActive(value);
            m_RoundInfo.gameObject.SetActive(value);
        }
    }

    public GameSpeed GameSpeed
    {
        get
        {
            return m_GameSpeed;
        }

        set
        {
            m_GameSpeed = value;
            m_ButtonSpeed1.gameObject.SetActive(value == GameSpeed.SpeedOne);
            m_ButtonSpeed2.gameObject.SetActive(value == GameSpeed.SpeedTwo);
        }
    }

    public int Gold
    {
        get
        {
            return m_Gold;
        }

        set
        {
            m_Gold = value;
            m_GoldText.text = value.ToString();
        }
    }
    #endregion

    #region 方法
    public void LoadRoundInfo(int current, int total)
    {
        m_CurrentText.text = current.ToString("D2");
        m_TotalText.text = total.ToString();
    }
    public void PauseBtnClick()
    {
        IsPlaying = true;
    }
    public void ContinueBtnClick()
    {
        IsPlaying = false;
    }

    public void SpeedOneBtnClick()
    {
        GameSpeed = GameSpeed.SpeedTwo;
    }
    public void SpeedTwoBtnClick()
    {
        GameSpeed = GameSpeed.SpeedOne;
    }

    public void MenuBtnClick()
    {

    }

    #endregion

    #region Unity回调
    private void Awake()
    {

    }

    private void Start()
    {
        // 获取到各个组件的引用
        m_GoldText = transform.Find("GoldText").GetComponent<Text>();
        //Image
        m_RoundInfo = transform.Find("RoundInfo").GetComponent<Image>();
        m_PauseImage = transform.Find("PauseInfo").GetComponent<Image>();
        //Text
        m_CurrentText = transform.Find("RoundInfo/Current").GetComponent<Text>();
        m_CurrentText = transform.Find("RoundInfo/Current").GetComponent<Text>();
        //Button
        m_ButtonSpeed1 = transform.Find("ButtonSpeed1").GetComponent<Button>();
        m_ButtonSpeed2 = transform.Find("ButtonSpeed2").GetComponent<Button>();
        m_ButtonPause = transform.Find("ButtonPause").GetComponent<Button>();
        m_ButtonContinue = transform.Find("ButtonCoutinue").GetComponent<Button>();



        IsPlaying = true;
        Gold = 0;
        GameSpeed = GameSpeed.SpeedOne;




    }

    private void Update()
    {

    }
    #endregion

    #region 事件回调

    public override void HandleEvent(string eventName, object data = null)
    {

    }

    #endregion

    #region 帮助方法
    #endregion




}
