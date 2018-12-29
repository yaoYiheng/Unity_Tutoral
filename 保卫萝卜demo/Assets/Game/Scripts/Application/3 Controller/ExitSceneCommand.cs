using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSceneCommand : Controller
{
    //退出一个场景时要做的任务, 在这里执行.
    public override void Execute(object data)
    {
        //离开当前场景前需要回收所有场景内可回收的游戏对象
        Game.Instance.ObjectPool.UnSpawnAll();
    }
}
