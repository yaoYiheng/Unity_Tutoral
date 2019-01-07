using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUpCommand : Controller
{
    //这个类需要将MVC框架注册到系统当中
    // 是第一次加载, 完成跳转场景的任务
    public override void Excute(object data)
    {
        // 注册数据

        // 注册控制器


        //数据的初始化


        //场景的第一跳
        Game.Instance.LoadScene(1);
    }
}
