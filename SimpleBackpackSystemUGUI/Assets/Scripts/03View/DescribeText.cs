using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescribeText : Singleton<DescribeText> {


    private Text m_DescribeText;
	// Use this for initialization
	void Start () 
    {
        m_DescribeText = transform.GetComponent<Text>();
        Hide();
	}
	

    public void UpdateText(string content)
    {
        m_DescribeText.text = content;
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }
    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

    public void SetLocalPosition(Vector2 postion)
    {
        transform.localPosition = postion;
    }
}
