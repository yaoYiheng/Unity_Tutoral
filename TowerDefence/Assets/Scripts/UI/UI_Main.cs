using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Main : UILayer
{
    public Text m_TextTitle;
    public Button m_ButtonStart;

    /// 相关初始化
    private void Start()
    {
        this.__init_node(transform);

    }
    public override void OnNodeAsset(string name, GameObject gameObject)
    {
        switch (name)
        {
            case "Text_Title":
                m_TextTitle = gameObject.GetComponent<Text>();

                break;

            case "Button_Start":
                m_ButtonStart = gameObject.GetComponent<Button>();
                break;
        }
    }



    public override void OnButtonClick (string name, GameObject gameObject)
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
