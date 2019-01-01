using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : View
{

    #region 常量
    private const string PREFAB_NAME = "Monster";
    #endregion

    #region 事件
    #endregion

    #region 字段

    Map m_Map = null;
    Luobo m_Luobo = null;
    #endregion

    #region 属性
    public override string Name
    {
        get {return Const.V_Spawner;}
    }
    #endregion

    #region 方法

    public void SpawnWeapon(SpawnWeaponArgs args)
    {
        //从地图的引用中获取到格子信息
        GridInfo grid = m_Map.GetGridInfo(args.Position);

        WeaponInfo info = Game.Instance.StaticData.GetWeaponInfo(args.TowerID);
        //从对象池中获取塔
        GameObject gameObject = Game.Instance.ObjectPool.OnSpawn(info.PrefabName);
        DontDestroyOnLoad(gameObject);
        gameObject.transform.position = args.Position;

        Tower tower = gameObject.GetComponent<Tower>();
        tower.Load(args.TowerID, grid);
    }
    public void SpawnerLuobo(Vector3 position)
    {
        string prefabName = "Luobo";

        GameObject go = Game.Instance.ObjectPool.OnSpawn(prefabName);

        DontDestroyOnLoad(go);
            //获取萝卜脚本组件
        Luobo  luobo = go.GetComponent<Luobo>();
        luobo.transform.position = position;
        luobo.OnRoleDead += Luobo_OnRoleDead;
        luobo.OnHealthPointChange += Luobo_OnHealthPointChange;

        //赋值
        m_Luobo = luobo;



    }
    //出怪
    public void SpawnMonster(int monsterID)
    {
        Debug.Log("开始生成怪物: " + monsterID);
        //从对象池中获取
        string prefabName = PREFAB_NAME + monsterID;

        GameObject go = Game.Instance.ObjectPool.OnSpawn(prefabName);   
        DontDestroyOnLoad(go);
            //绑定相应的事件
        Monster monster = go.GetComponent<Monster>();
        monster.OnHealthPointChange += Monster_OnHealthPointChange;
        monster.OnReached += Monster_OnReached;
        monster.OnRoleDead += Monster_OnRoleDead;

        
        //从本类的属性中加载地图中的path
        monster.LoadPath(m_Map.Path);
    }
    #endregion

    #region Unity回调
    #endregion

    #region 事件回调
    void Map_OnGridClick(object sender, GridClickEventArgs args)
    {
        
        GameModel gameModel = GetModel<GameModel>();
        if(!gameModel.IsPlaying || !args.Grid.CanHold) return;
        print("Map_OnGridClick");
        //如果是空格子, 则放置炮塔
        if(args.Grid.Data == null)
        {
            //发布显示创建炮塔的事件以及其所需要的参数
            ShowCreatPanelArgs show = new ShowCreatPanelArgs()
            {
                Position = m_Map.GetGridPosition(args.Grid),
                //当格子的Y值大于行数的1/2时
                IsUpside = args.Grid.Y < Map.RowCount / 2
            };
            SendEvent(Const.E_ShowCreatPanel, show);
        }
        else
        {
            ShowUpgradePanelArgs arg = new ShowUpgradePanelArgs()
            {
                Tower = args.Grid.Data as Tower
            };
            SendEvent(Const.E_ShowUpgradePanel, arg);
        }
    }
    void Monster_OnRoleDead(Role role)
    {
        Game.Instance.ObjectPool.UnSpawn(role.gameObject);


        GameModel gameModel = GetModel<GameModel>();
        RoundModel roundModel = GetModel<RoundModel>();
        //场景中没有存在的怪物
        //已经加载完所有的怪物
        //萝卜还活着.
        GameObject[] monsters = GameObject.FindGameObjectsWithTag("Monster");
        //通过tag并不能找到设置为不可用的游戏对象
        if(monsters.Length == 0 &&
        !m_Luobo.IsDead && 
        roundModel.IsAllCompleted)
        {
            // 游戏获胜
            SendEvent(Const.E_EndLevel, new EndLevelArgs(){LevelIndex = gameModel.PlayingLevelIndex, IsSuccessed = true});
        }
    }
    void Monster_OnReached(Role role)
    {
        //接触到萝卜后将怪物的生命值设置为0, 并且将萝卜的血量-1操作
        m_Luobo.Damage(1);
        role.CurrentHP = 0;

    }
    void Monster_OnHealthPointChange(int currentHP, int maxHP)
    {

    }
    void Luobo_OnRoleDead(Role role)
    {
        //回收萝卜
        Game.Instance.ObjectPool.UnSpawn(role.gameObject);
        GameModel gameModel = GetModel<GameModel>();
        SendEvent(Const.E_EndLevel, new EndLevelArgs(){LevelIndex = gameModel.PlayingLevelIndex, IsSuccessed = false});
    }
    void Luobo_OnHealthPointChange(int currentHP, int maxHP)
    {
        
    }
    public override void RegisterEvent()
    {
        this.AttentionEvents.Add(Const.E_EnterScene);
        this.AttentionEvents.Add(Const.E_SpawnMonster);

        this.AttentionEvents.Add(Const.E_SpawnWeapon);
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
                m_Map.OnGridClick += Map_OnGridClick;
                
                GameModel model = GetModel<GameModel>();
                m_Map.LoadLevel(model.PlayingLevel);

                //从地图中获取到路径中最后一个点
                SpawnerLuobo(m_Map.Path[m_Map.Path.Length - 1]);

            }

            break;
            
            case Const.E_SpawnMonster:

                MonsterArgs args = data as MonsterArgs;

                SpawnMonster(args.MonsterID);

            break;

            case Const.E_SpawnWeapon:
                SpawnWeaponArgs args1 = data as SpawnWeaponArgs;
                SpawnWeapon(args1);

            break;
        }
    }
    #endregion

    #region 帮助方法
    #endregion
    

}