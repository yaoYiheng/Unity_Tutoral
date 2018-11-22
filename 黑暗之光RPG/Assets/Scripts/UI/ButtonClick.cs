using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnNewGameClick()
    {
        print("点击加载新游戏");
        SceneManager.LoadScene(1);
    }

    public void OnLoadGameClick()
    {
        print("点击加载已存在游戏");
    }
}
