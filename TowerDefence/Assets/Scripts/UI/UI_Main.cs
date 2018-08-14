﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Main : MonoBehaviour
{
    public Text m_TextTitle;
    public Button m_ButtonStart;
    // Use this for initialization

    /// <summary>
    /// 获取相关组件
    /// </summary>
    private void Awake()
    {
        this.m_TextTitle = this.transform.Find("Text_Title").GetComponent<Text>();
        this.m_ButtonStart = this.transform.Find("Button_Start").GetComponent<Button>();

    }
    /// <summary>
    /// 相关初始化
    /// </summary>
    private void Start()
    {
        m_TextTitle.text = "3D塔防练习";
        //给按钮添加点击事件
        m_ButtonStart.onClick.AddListener(() =>
        {
            Debug.Log("点击");
        });
    }
}
