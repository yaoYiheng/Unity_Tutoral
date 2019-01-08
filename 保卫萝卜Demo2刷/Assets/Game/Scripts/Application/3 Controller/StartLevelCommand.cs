using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevelCommand : Controller
{
    public override void Excute(object data)
    {
        StarLevelArgs args = data as StarLevelArgs;

        Game.Instance.LoadScene(3);
    }
}
