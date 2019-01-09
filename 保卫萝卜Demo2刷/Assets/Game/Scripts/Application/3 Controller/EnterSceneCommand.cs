using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterSceneCommand : Controller
{
    public override void Excute(object data)
    {
        SceneIndexArgs args = data as SceneIndexArgs;

        switch (args.SceneIndex)
        {
            case 2:
                RegisterView(GameObject.Find("UISelect").GetComponent<UISelect>());
                break;
            case 3:
                RegisterView(GameObject.Find("UIBoard").GetComponent<UIBoard>());
                RegisterView(GameObject.Find("UICountDown").GetComponent<UICountDown>());
                break;
            default:
                break;
        }
    }
}
