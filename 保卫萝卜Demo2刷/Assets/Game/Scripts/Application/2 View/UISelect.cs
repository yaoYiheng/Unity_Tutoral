using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISelect : View
{
    public override string Name
    {
        get
        {
            return Consts.V_Select;
        }
    }

    public override void HandleEvent(string eventName, object data = null)
    {

    }

    public void GotoStartScene()
    {
        Game.Instance.LoadScene(1);
    }

    public void StartLevel()
    {

        StarLevelArgs args = new StarLevelArgs() { LevelCardIndex = 0 };
        SendEvent(Consts.E_StartLevel, args);
    }
}
