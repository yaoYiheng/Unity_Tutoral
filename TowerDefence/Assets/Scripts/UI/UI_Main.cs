using System.Collections;
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
        //this.m_TextTitle = this.transform.Find("Text_Title").GetComponent<Text>();
        //this.m_ButtonStart = this.transform.Find("Button_Start").GetComponent<Button>();

    }
    public void __init_node(Transform transform)
    {
        OnNodeAsset(transform.name, transform.gameObject);
        Button button = transform.GetComponent<Button>();
        if(button != null)
        {
            button.onClick.AddListener(() =>
            {
                OnButtonClick(button.name, button.gameObject);
            });
        }
        for (int i = 0; i < transform.childCount;i++)
        {
            this.__init_node(transform.GetChild(i));
        }
    }

    public void OnNodeAsset(string name, GameObject gameObject)
    {
        switch (name)
        {
            case "Text_Title":
                m_TextTitle = gameObject.GetComponent<Text>();
                m_TextTitle.text = "3D塔防练习";
                break;

            case "Button_Start":
                m_ButtonStart = gameObject.GetComponent<Button>();
                break;
        }
    }
    /// <summary>
    /// 相关初始化
    /// </summary>
    private void Start()
    {
        this.__init_node(transform);
        //m_TextTitle.text = "3D塔防练习";
        //给按钮添加点击事件
        //m_ButtonStart.onClick.AddListener(() =>
        //{
        //    OnButtonClick(m_ButtonStart.name, m_ButtonStart.gameObject);
        //});

        //Button button_Close = transform.Find("Button_Close").GetComponent<Button>();
        //button_Close.onClick.AddListener(() =>
        //{
        //    OnButtonClick(button_Close.name, button_Close.gameObject);
        //});
        //Button button_Close_All = transform.Find("Button_Close_All").GetComponent<Button>();
        //button_Close_All.onClick.AddListener(() =>
        //{
        //    OnButtonClick(button_Close_All.name, button_Close.gameObject);
        //});
        //Button button_Show = transform.Find("Button_Show").GetComponent<Button>();
        //button_Show.onClick.AddListener(() =>
        //{
        //    OnButtonClick(button_Show.name, button_Show.gameObject);
        //});
    }

    public void OnButtonClick (string name, GameObject gameObject)
    {
        switch (name)
        {
            case "Button_Close":
                UIManager.ExitUI(this);
                break;
            
            case "Button_Close_All":
                UIManager.ExitAllUI();
                break;

            case "Button_Show":
                UIManager.EnterUI<UI_Main>();
                break;

            case"Button_Start":
                Debug.Log("游戏开始");
                break;

            default:
                break;
        }
    }
}
