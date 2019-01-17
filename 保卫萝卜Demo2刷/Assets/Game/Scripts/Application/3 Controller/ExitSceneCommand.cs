using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSceneCommand : Controller
{

    public override void Excute(object data)
    {
        //离开场景的时候, 清除一切可以回收的
        Game.Instance.ObjectPool.UnSpawnAll();

    }
}
