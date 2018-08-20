using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadImage : MonoBehaviour {

    //图片URL
    private string url = "https://ss0.baidu.com/6ONWsjip0QIZ8tyhnq/it/u=785011176,3267677792&fm=173&app=25&f=JPEG?w=640&h=960&s=9180F117490EF4CE0A4590DE03008060";
    //用来显示的组件
    public RawImage rawImage;
	// Use this for initialization
	void Start () {
        StartCoroutine(loadBmp());
	}

    private void StartCoroutine(IEnumerator enumerator)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update () {
		
	}
    //防止下载阻塞, 使用携程
    IEnumerator loadBmp()
    {
        WWW wWW = new WWW(url);

        yield return wWW;

        rawImage.texture = wWW.texture;
    }
}
