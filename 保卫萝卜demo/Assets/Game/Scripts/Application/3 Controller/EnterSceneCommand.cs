 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//进入场景是会调用的控制器
public class EnterSceneCommand : Controller
{
    public override void Execute(object data)
    {
        SceneArgs args = data as SceneArgs;
        switch (args.Level)
        {
            case 0:
                break;
            case 1:
                RegisterView(GameObject.Find("UIStart").GetComponent<UIStart>());
                break;
            case 2:
                RegisterView(GameObject.Find("UISelect").GetComponent<UISelect>());
                break;
            case 3:

                RegisterView(GameObject.Find("Map").GetComponent<Spawner>());
                RegisterView(GameObject.Find("UIBoard").GetComponent<UIBoard>());
                //对于一开始就隐藏的UI控件
                RegisterView(GameObject.Find("Canvas").transform.Find("UICountDown").GetComponent<UICountDown>());
                RegisterView(GameObject.Find("Canvas").transform.Find("UIWin").GetComponent<UIWin>());
                RegisterView(GameObject.Find("Canvas").transform.Find("UILost").GetComponent<UILost>());
                RegisterView(GameObject.Find("Canvas").transform.Find("UISystem").GetComponent<UISystem>());

                break;
            case 4:
                RegisterView(GameObject.Find("UIComplete").GetComponent<UIComplete>());
                break;
            default: break;
        }
    }
}
