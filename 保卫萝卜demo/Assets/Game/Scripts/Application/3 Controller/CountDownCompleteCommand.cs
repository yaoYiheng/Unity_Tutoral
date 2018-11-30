using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownCompleteCommand : Controller
{
    public override void Execute(object data)
    {
        Game.Instance.LoadScene(4);
    }
}