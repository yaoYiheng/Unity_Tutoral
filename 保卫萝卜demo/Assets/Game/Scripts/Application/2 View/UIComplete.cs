using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIComplete : View
{
    
    public override string Name
    {
        get
        {
            return Const.V_UIComplete;
        }
    }

    public override void HandleEvent(string eventName, object data)
    {
        
    }

    public void OnRestartClick()
    {
        //跳转到最初的场景
        Game.Instance.LoadScene(1);
    }

    public void OnClearClick()
    {
        //完成清档操作
    }
}