using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class UISelect : View
{


    #region 常量
    #endregion

    #region 事件
    #endregion

    #region 字段
    GameModel m_GameModel = null;
    List<CardInfo> m_CardInfos = new List<CardInfo>();

    int m_SelectIndex = -1;
    #endregion

    #region 属性

    public override string Name
    {
        get
        {
            return  Const.V_Select; 
        }
    }



    #endregion




    #region 方法
    public void GoBack()
    {
        Game.Instance.LoadScene(1);
    }

    public void ChooseLevel()
    {

        
        //添加事件
        //初始化事件参数
        StartLevelArgs args = new StartLevelArgs() { LevelIndex = m_SelectIndex };


        //向系统发送事件, 和与事件相关的参数.
        SendEvent(Const.E_StartLevel, args);

    }

    //加载卡片
    public void LoadCards()
    {
         //将文件列表加载到内存
        //构建Level集合

        //得到所有Level的文件
        //将level文件写入到Level类中
        List<Level> levels = m_GameModel.AllLevels;

        
        //构建Card集合
        List<CardInfo> cardInfos = new List<CardInfo>();
        for (int i = 0; i < levels.Count; i++)
        {
            CardInfo card = new CardInfo();
            card.LevelID = i; 
            card.CardName = levels[i].CardImage;
            //Todo
            card.isLocked = i > m_GameModel.GameProgress + 1;

            cardInfos.Add(card);
        }
        this.m_CardInfos = cardInfos;


        //为UIcard添加监听
        UICard[] cards = transform.Find("UICards").GetComponentsInChildren<UICard>();
        foreach (UICard item in cards)
        {
            item.OnCardClick += (card) =>
            {
                SelecteCard(card.LevelID);
            };
        }


        //默认选择第1个卡片
        SelecteCard(0);

    }
    #endregion

    #region Unity回调
    #endregion

    #region 事件回调

    public override void RegisterEvent()
    {
        this.AttentionEvents.Add(Const.E_EnterScene);
    }
    public override void HandleEvent(string eventName, object data)
    {
        SceneArgs args = data as SceneArgs;
        switch(args.Level)
        {
            case 2:
            //获取模型数据
            m_GameModel = GetModel<GameModel>();

            // print(GetModel<GameModel>().LevelCount);
            // print("从MVC中加载的Model关卡数:" +GetModel<GameModel>().LevelCount);
            // print("关卡个数: " + m_GameModel.LevelCount);
            LoadCards();
            
            break;
        }
    } 
    #endregion

    #region 帮助方法

    void SelecteCard(int index)
    {   

        if(m_SelectIndex == index) return;

        m_SelectIndex = index;

        //计算index
        int leftIndex = m_SelectIndex - 1;
        int currentIndex = m_SelectIndex;
        int rightIndex = m_SelectIndex + 1;

        //获取到UISelect下的UICars
        Transform container = this.transform.Find("UICards");




        //根据Index决定各个组件的显示与否与显示的数据
        if(leftIndex < 0)
        {
            //获取到container下的第一个子控件
            container.GetChild(0).gameObject.SetActive(false);
        }
        else
        {   //根据m_CardInfos里的数据, 设置到UICard上并显示
            container.GetChild(0).gameObject.SetActive(true);
            container.GetChild(0).GetComponent<UICard>().IsTransparent = true;
            container.GetChild(0).GetComponent<UICard>().DataBind(m_CardInfos[leftIndex]);
        }



        //设置当前正中的UICard
        container.GetChild(1).GetComponent<UICard>().IsTransparent = false;
        container.GetChild(1).GetComponent<UICard>().DataBind(m_CardInfos[currentIndex]);

        if(rightIndex >= m_CardInfos.Count)
        {
            //获取到container下的第一个子控件
            container.GetChild(2).gameObject.SetActive(false);
        }
        else
        {   //根据m_CardInfos里的数据, 设置到UICard上并显示
            container.GetChild(2).gameObject.SetActive(true);
            container.GetChild(2).GetComponent<UICard>().IsTransparent = true;
            container.GetChild(2).GetComponent<UICard>().DataBind(m_CardInfos[rightIndex]);
        }

    }
    #endregion

}
