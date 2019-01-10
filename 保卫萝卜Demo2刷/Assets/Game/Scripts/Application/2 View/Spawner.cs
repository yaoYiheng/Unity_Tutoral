using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : View
{


    #region 常量
    #endregion

    #region 事件
    #endregion

    #region 字段
    //地图
    Map m_Map;
    #endregion

    #region 属性
    public override string Name
    {
        get
        {
           return Consts.V_Spawner;
        }
    }

    #endregion

    #region 方法
    public void SpawnMonster(int monsterID)
    {
        Debug.Log("正在出" + monsterID);
    }
    #endregion

    #region Unity回调
    #endregion

    #region 事件回调
    public override void AddEventToList()
    {
        //这个视图关注的事件
        // 进入场景
        AttentionEventList.Add(Consts.E_EnterScene);
        //倒计时结束
        AttentionEventList.Add(Consts.E_SpawnMonster);


    }

    public override void HandleEvent(string eventName, object data = null)
    {
        switch (eventName)
        {
            case Consts.E_EnterScene:
                SceneIndexArgs sceneIndex = data as SceneIndexArgs;
                if (sceneIndex.SceneIndex == 3)
                {
                   //进入到第三场景时, 给地图赋值;
                   m_Map = GetComponent<Map>();

                   //从游戏数据中获取到当前正在玩的关卡的level, 
                   //同时地图也需要level中的数据
                   GameModel gameModel = GetModel<GameModel>();
                   m_Map.LoadLevel(gameModel.CurrerntLevel);
                }

                break;
            case Consts.E_SpawnMonster:
                //开始出怪
                SpawnMonsterArgs monsterArgs = data as SpawnMonsterArgs;

                SpawnMonster(monsterArgs.MonsterID);

                break;
            default:
                break;
        }
    }
    #endregion

    #region 帮助方法
    #endregion


}
