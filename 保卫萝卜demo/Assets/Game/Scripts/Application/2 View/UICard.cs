using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class UICard : MonoBehaviour, IPointerDownHandler 
{
    public Image imgCard;
    public Image imgLock;

    //添加点击事件.
    public event Action<CardInfo> OnCardClick;

    private CardInfo m_CardInfo = null;

    public bool m_IsLocked;
    public bool m_IsTransparent;

    public bool IsLocked
    {
        get
        {
            return m_IsLocked;
        }

        set
        {
            m_IsLocked = value;
            imgLock.gameObject.SetActive(value);
        }
    }

    public bool IsTransparent
    {
        get
        {
            return m_IsTransparent;
        }

        set
        {
            m_IsTransparent = value;
            Image[] images = new Image[] { imgCard, imgLock };

            foreach(Image img in images)
            {
                Color color = img.color;
                color.a = value ? 0.5f : 1.0f;
                img.color = color;
            }
        }
    }

    //将传入的CardInfo绑定到UI上
    public void DataBind(CardInfo cardInfo)
    {
        //保存传入的CardInfo
        m_CardInfo = cardInfo;

        //获取到存放图片的全路径
        string filePath = "file://" + Const.CardPath + cardInfo.CardName;


        StartCoroutine(Tools.LoadImage(filePath, imgCard));

        //设置锁的显示与否
        imgLock.gameObject.SetActive(cardInfo.isLocked);

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(OnCardClick != null)
        {
            OnCardClick(m_CardInfo);
        }
    }

    private void OnDestroy()
    {
        while(OnCardClick != null)
        {
            OnCardClick -= OnCardClick;
        }
    }
}