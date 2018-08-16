using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Main : UILayer
{
    public Text m_TextTitle;
    public Button m_ButtonStart;

    public override void OnNodeLoad()
    {
        base.OnNodeLoad();
        m_TextTitle.text = "3D塔防练习";
    }
    public override void OnEnter()
    {
        base.OnEnter();
    }
    public override void OnExit()
    {
        base.OnExit();
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
                Close();
                break;
            
            case "Button_Close_All":
                UIManager.ExitAllUI();
                break;

            case "Button_Show":
                UIManager.EnterUI<UI_Main>();
                break;

            case"Button_Start":
                Debug.Log("游戏开始");
                Close();
                UIManager.EnterUI<UI_Battle>();

                break;

            default:
                break;
        }
    }
}
