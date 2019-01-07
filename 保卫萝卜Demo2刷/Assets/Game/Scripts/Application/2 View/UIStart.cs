using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStart : View
{
    public override string Name
    {
        get
        {
            return Consts.V_Start;
        }
    }

    public override void HandleEvent(string eventName, object data = null)
    {

    }

    public void Goto()
    {
        Game.Instance.LoadScene(2);
    }
}