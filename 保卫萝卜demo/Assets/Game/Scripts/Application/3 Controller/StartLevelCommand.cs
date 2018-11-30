using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevelCommand : Controller
{
    public override void Execute(object data)
    {

        //当接受到进入关卡的事件后, 跳转到LevelScene

        Game.Instance.LoadScene(3);
    }
}
