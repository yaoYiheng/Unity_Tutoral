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
    Luobo m_Luobo;
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

    void SpawneLuobo(Vector3 position)
    {
        string luoboName = "Luobo";
        GameObject go = Game.Instance.ObjectPool.OnSpawn(luoboName);
        DontDestroyOnLoad(go);

        Luobo luobo = go.GetComponent<Luobo>();
        luobo.Dead += Luobo_Dead;

        //给定萝卜的位置
        luobo.transform.position = position;

        //给萝卜赋值
        m_Luobo = luobo;

    }

    /// <summary>
    /// 萝卜死亡
    /// 意味着本轮游戏失败, 需要进行Luobo对象的回收以及发送失败的事件
    /// </summary>
    /// <param name="obj">Object.</param>
    void Luobo_Dead(Role obj)
    {
        //print("spawner");
        Game.Instance.ObjectPool.UnSpawn(obj.gameObject);
        GameModel gameModel = GetModel<GameModel>();
        //发送事件
        SendEvent(Consts.E_EndLevel, new EndLevelArgs() { IsWin = false, EndLevelIndex = gameModel.CurrentPlayingIndex });
    }


    void SpawnMonster(int monsterID)
    {
        
        string monsterName = "Monster" + monsterID;


        GameObject monsterGo = Game.Instance.ObjectPool.OnSpawn(monsterName);

        DontDestroyOnLoad(monsterGo);

        //获取到挂在对象上的脚本组件, 对相关事件以及所需数据进行绑定与赋值
        Monster monster = monsterGo.GetComponent<Monster>();
        monster.Reach += Monster_Reach;
        monster.Dead += Monster_Dead;
        monster.HealthChange += Monster_HealthChange;

        //加载怪物所行走的路径.
        monster.LoadPath(m_Map.MonsterPath);

    }
    void SpawnTower(SpawnTowerArgs spawnTowerArgs)
    {
        print("来?");
        //获取格子
        GridInfo gridInfo = m_Map.GetGridByPosition(spawnTowerArgs.Position);
        
        TowerInfo towerInfo = Game.Instance.StaticData.GetTowerInfo(spawnTowerArgs.TowerID);

        GameObject towerGo = Game.Instance.ObjectPool.OnSpawn(towerInfo.PrefabName);
        DontDestroyOnLoad(towerGo);
        Tower tower = towerGo.GetComponent<Tower>();
        tower.transform.position = spawnTowerArgs.Position;

        tower.LoadData(spawnTowerArgs.TowerID, gridInfo, m_Map.GetRect);

        gridInfo.data = tower;

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
        // 生成炮塔
        AttentionEventList.Add(Consts.E_SpawnTower);


    }
    //怪物掉血
    void Monster_HealthChange(int arg1, int arg2)
    {
    }

    //怪物死亡
    // 需要添加金币
    void Monster_Dead(Role obj)
    {

        GameModel gameModel = GetModel<GameModel>();

        if(!m_Luobo.IsDead)
        {
            Monster monster = obj as Monster;
            MonsterInfo info = StaticData.Instance.GetMonsterInfo(monster.MonsterID);

            gameModel.Gold += info.Gold;
     
        }

        SendEvent(Consts.E_MonsterDead);

        Game.Instance.ObjectPool.UnSpawn(obj.gameObject);

        //同时需要判断这个怪死了之后是否达成胜利的条件
        //场景中没怪物
        //萝卜没死
        // 所有怪已经出完
        //获取场景中所有怪
        //通过tag并不能找到设置为不可用的游戏对象, 所以如果这个数组的长度为0, 则说明场景中没有存活的怪物
        GameObject[] monsters = GameObject.FindGameObjectsWithTag("Monster");
        RoundModel roundModel = GetModel<RoundModel>();
        var isWin = !m_Luobo.IsDead && monsters.Length == 0 && roundModel.IsCompleted;

        if (isWin)
        {
            //发送胜利事件
            SendEvent(Consts.E_EndLevel, new EndLevelArgs() { IsWin = true, EndLevelIndex = gameModel.CurrentPlayingIndex });
        }
    }

    //怪物到达目的地
    // 对萝卜进行伤害.
    void Monster_Reach(Monster obj)
    {
        m_Luobo.OnDamage(1);
        obj.CurrentHP = 0;
    }

    //地图上的格子被点击的时候.
    void M_Map_OnGridClick(object sender, GridClickEventArgs e)
    {
        print("点击");
        // 游戏未开始时, 不能相应点击
        GameModel gameModel = GetModel<GameModel>();
        if (!gameModel.IsPlaying) return;

        if (e.GridInfo == null)
        {
            return;
        }
        // 当场上的格子不能放置炮塔时, 不相应点击事件
        if (!e.GridInfo.CanHold) 
        {
            SendEvent(Consts.E_HideAllPanels);
            return;
        }
            // 当格子被点击时, 有交互菜单时, 隐藏场上所有菜单
        if (TowerPopup.Instance.IsPanelShow())
        {
            //TowerPopup.Instance.HideAllPanels();
            SendEvent(Consts.E_HideAllPanels);
            return;
        }
           

        //如果被点击的格子是空格子, 发送出显示创建炮塔的消息
        if (e.GridInfo.data == null)
        {
            CreatPanelArgs creatPanelArgs = new CreatPanelArgs()
            {
                Position = m_Map.GetGridPosition(e.GridInfo),
                IsUpside = e.GridInfo.Y < Map.RowCount / 2
            };
            SendEvent(Consts.E_ShowCreatPanel, creatPanelArgs);
        }
        //如果给点击的格子已有数据, 则发送升级炮塔的消息
        else
        {
            print("来这里?");
        }
       

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
                    m_Map.OnGridClick += M_Map_OnGridClick;
                   //从游戏数据中获取到当前正在玩的关卡的level, 
                   //同时地图也需要level中的数据
                   GameModel gameModel = GetModel<GameModel>();
                   m_Map.LoadLevel(gameModel.CurrerntLevel);

                    //生成萝卜
                    SpawneLuobo(m_Map.MonsterPath[m_Map.MonsterPath.Length - 1]);

                }

                break;
            case Consts.E_SpawnMonster:
                //开始出怪
                SpawnMonsterArgs monsterArgs = data as SpawnMonsterArgs;

                SpawnMonster(monsterArgs.MonsterID);

                break;
            case Consts.E_SpawnTower:
                SpawnTowerArgs spawnTowerArgs = data as SpawnTowerArgs;
                SpawnTower(spawnTowerArgs);

                break;
            default:
                break;
        }
    }
    #endregion

    #region 帮助方法
    #endregion


}
