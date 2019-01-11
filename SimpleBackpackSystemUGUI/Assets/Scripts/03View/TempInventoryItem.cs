using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempInventoryItem : Singleton<TempInventoryItem>
{
    private Image m_Icon;

    public string Icon
    {
        set
        {
            string path = "file://" + Consts.IconPath + value;


            StartCoroutine(Tools.LoadImage(path, m_Icon));


        }
    }

    protected override void Awake()
    {
        base.Awake();
        m_Icon = GetComponent<Image>();
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
