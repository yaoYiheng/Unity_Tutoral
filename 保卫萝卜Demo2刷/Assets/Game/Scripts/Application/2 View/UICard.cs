using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
/// 这个类的作用 需要用来显示关卡的情况
/// 比如显示不同的关卡图片 => m_CardImage
/// 这个关卡是否已经被打通 => m_IsLocked;
/// 用来设置这View的数据 =>m_CardInfo
/// 
/// 这个类, 还需要响应点击事件. 当这个类所在的UI被点击时, 需要抛出一个事件, 并将CardInfo作为
/// 事件参数抛出
/// </summary>
public class UICard : MonoBehaviour, IPointerDownHandler
{
    public event Action<CardInfo> OnCardClick;

    private Image m_CardImage;
    private Image m_LockImage;
    // Use this for initialization

    //CardInfor类, 用来给UICard提供数据
    private CardInfo m_CardInfo;


    private bool m_IsTransparent;

    public bool IsTransparent
    {
        get
        {
            return m_IsTransparent;
        }

        set
        {
            m_IsTransparent = value;
            //根据是否半透明, 来设置图片的半透
            Image[] images = { m_CardImage, m_LockImage };
            foreach (var item in images)
            {
                Color color = item.color;

                color.a = value ? 0.5f : 1.0f;

                item.color = color;
            }
        }
    }

    void Awake()
    {

        //因为这个脚本是直接挂在UICard上, 
        // 而UICard上以及包含了组件Image, 在获取想要Image组件时, 可以直接调用GetComponent<>();

        m_CardImage = transform.GetComponent<Image>();
        //这个组件是该脚本所在的游戏对象的子对象. 所以需要使用Find()进行查找到游戏对象后, 在获取Image组件.
        m_LockImage = transform.Find("Lock").GetComponent<Image>();

    }


    public void LoadCardInfo(CardInfo cardInfo)
    {
        m_CardInfo = cardInfo;

        string url = "file://" +Consts.CardPath + cardInfo.CardName;
        //设置关卡的图片
        StartCoroutine(Tools.LoadImage(url, m_CardImage));

        //是否显示加锁
        m_LockImage.gameObject.SetActive(cardInfo.IsLocked);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (OnCardClick != null)
        {
            OnCardClick(m_CardInfo);
        }
    }

    private void OnDestroy()
    {
        while (OnCardClick!=null)
        {
            OnCardClick -= OnCardClick;
        }
    }
}
