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

    Map m_Map = null;
    #endregion

    #region 属性
    public override string Name
    {
        get {return Const.V_Spawner;}
    }
    #endregion

    #region 方法
    //出怪
    public void SpawnMonster(int monsterID)
    {
        Debug.Log("开始生成怪物: " + monsterID);
    }
    #endregion

    #region Unity回调
    #endregion

    #region 事件回调

    public override void RegisterEvent()
    {
        this.AttentionEvents.Add(Const.E_EnterScene);
        this.AttentionEvents.Add(Const.E_SpawnMonster);
    }

    public override void HandleEvent(string eventName, object data)
    {
        switch(eventName)
        {
            case Const.E_EnterScene:
            //进入场景时, 加载地图
            SceneArgs args0 = data as SceneArgs;

            if(args0.Level == 3)
            {
                m_Map = GetComponent<Map>();
                
                GameModel model = GetModel<GameModel>();
                m_Map.LoadLevel(model.PlayingLevel);

            }

            break;

            case Const.E_SpawnMonster:

                MonsterArgs args = data as MonsterArgs;
;
                SpawnMonster(args.MonsterID);

            break;
        }
    }
    #endregion

    #region 帮助方法
    #endregion
    

}