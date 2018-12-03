using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStart : View 
{
    public override string Name
    {
        get
        {
            return Const.V_Start; 
        }
    }

    public override void HandleEvent(string eventName, object data)
    {
        
    }

    //跳转到选择关卡的场景
    public void GotoSelect()
    {

        Game.Instance.LoadScene(2);
    }


}
