﻿using System.Collections;
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
                View spawner = GameObject.Find("Map").GetComponent<Spawner>();
                RegisterView(spawner);

                RegisterView(GameObject.Find("TowerPopup").GetComponent<TowerPopup>());
                RegisterView(GameObject.Find("UIBoard").GetComponent<UIBoard>());
                RegisterView(GameObject.Find("UICountDown").GetComponent<UICountDown>());
                RegisterView(GameObject.Find("Canvas").transform.Find("UIWin").GetComponent<UIWin>());
                RegisterView(GameObject.Find("Canvas").transform.Find("UILost").GetComponent<UILost>());
                RegisterView(GameObject.Find("Canvas").transform.Find("UIMenu").GetComponent<UIMenu>());
                break;
            default:
                break;
        }
    }
}
