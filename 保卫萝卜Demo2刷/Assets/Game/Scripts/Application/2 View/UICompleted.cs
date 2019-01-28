using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICompleted : View
{
    public override string Name
    {
        get
        {
            return Consts.V_Completed;
        }
    }


    public void OnRestartClick()
    {
        Game.Instance.LoadScene(1);
    }
    public void OnClearClick()
    {
        GetModel<GameModel>().ClearProgress();
    }
    public override void AddEventToList()
    {
        base.AddEventToList();
    }

    public override void HandleEvent(string eventName, object data = null)
    {

    }
}
