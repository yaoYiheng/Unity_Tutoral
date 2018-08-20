using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonClick : MonoBehaviour {

    public Image imageA;

    private static int pressCount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        pressCount++;
        Debug.Log("按钮点击" + pressCount + "次");

        if(imageA != null)
        {
            RectTransform rect = imageA.rectTransform;
            rect.SetAsLastSibling();//覆盖在所有的UI之上

        }
    }
}
