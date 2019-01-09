using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class UISelect : View
{
    #region 常量
    #endregion

    #region 事件
    #endregion

    #region 字段
    Button StartButton;
    List<CardInfo> m_Cards = new List<CardInfo>();

    int m_SelectIndex = -1;

    GameModel m_GameModel = null;
    #endregion

    #region 属性
    public override string Name
    {
        get
        {
            return Consts.V_Select;
        }
    }

    #endregion

    #region 方法
    public void GotoStartScene()
    {
        Game.Instance.LoadScene(1);
    }

    public void StartLevel()
    {
        StarLevelArgs args = new StarLevelArgs() { LevelCardIndex = m_SelectIndex};
        SendEvent(Consts.E_StartLevel, args);
    }
    //UICard所需要的数据, 有一部分放在level类中.
    // 先获取所有的level类.
    void LoadLevels()
    {
        /*
        //获取所有的level文件集合
        List<FileInfo> fileInfos = Tools.GetLevelFiels();

        List<Level> levels = new List<Level>();
        //将level文件转换成level类
        foreach (var item in fileInfos)
        {
            Level level = new Level();

            Tools.FillLevel(item.FullName, ref level);

            levels.Add(level);
        }
        */
        List<Level> levels = m_GameModel.AllLevels;
        //根据Level类, 对CardInfo类对象赋值
        for (int i = 0; i < levels.Count; i++)
        {
            CardInfo cardInfo = new CardInfo()
            {
                LevelIndex = i,
                CardName = levels[i].CardImage,
                IsLocked = i > m_GameModel.GameProgress + 1
            };
            m_Cards.Add(cardInfo);
        }

        //对每一个UICard进行事件委托的绑定

        //获取所有的UIcard控件
        UICard[] cards = transform.Find("UICards").GetComponentsInChildren<UICard>();

        foreach (var item in cards)
        {
            item.OnCardClick += (card) =>
            {
                Select(card.LevelIndex);
            };
        }

        Select(0);

    }

    void Select(int index)
    {
        if (index == m_SelectIndex) return;

        StartButton.gameObject.SetActive(!m_Cards[index].IsLocked);

        m_SelectIndex = index;

        int right = m_SelectIndex + 1;
        int middle = m_SelectIndex;
        int left = m_SelectIndex - 1;


        //获取到UICards下的子元素
        Transform containers = transform.Find("UICards");
        // 对最左边的UICard控件进行赋值
        if (left < 0)
        {
            containers.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            containers.GetChild(0).gameObject.SetActive(true);
            containers.GetChild(0).transform.GetComponent<UICard>().IsTransparent = true;
            containers.GetChild(0).transform.GetComponent<UICard>().LoadCardInfo(m_Cards[left]);
        }

        //显示中间的
        containers.GetChild(1).transform.GetComponent<UICard>().LoadCardInfo(m_Cards[middle]);


        //显示最右
        if (right > m_Cards.Count - 1)
        {
            containers.GetChild(2).gameObject.SetActive(false);
        }
        else
        {
            containers.GetChild(2).gameObject.SetActive(true);
            containers.GetChild(2).transform.GetComponent<UICard>().IsTransparent = true;
            containers.GetChild(2).transform.GetComponent<UICard>().LoadCardInfo(m_Cards[right]);
        }
    }
    #endregion

    #region Unity回调
    #endregion

    #region 事件回调
    public override void AddEventToList()
    {
        AttentionEventList.Add(Consts.E_EnterScene);
    }
    public override void HandleEvent(string eventName, object data = null)
    {
        switch (eventName)
        {
            case Consts.E_EnterScene:

                SceneIndexArgs args = data as SceneIndexArgs;
                if (args.SceneIndex == 2)
                {
                    //当进入到该场景时 对游戏模型进行赋值
                    m_GameModel = GetModel<GameModel>();

                    StartButton = transform.Find("StartButton").GetComponent<Button>();
                    LoadLevels();
                }
                break;
            default:
                break;
        }
    }

    #endregion

    #region 帮助方法
    #endregion




}
