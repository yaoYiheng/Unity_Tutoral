using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Battle : UILayer 
{

    private int enemyAmout = 10;

    private void Update()
    {
        BattleManager.BattleUpdate();
    }
    public override void OnNodeLoad()
    {
        MapsManager.m_MapObj.transform.localPosition = Vector3.zero;
        //BattleManager.mPathList = MapsManager.GetPath("1");

        ////创建怪物
        //Enemy enemy_obj = EnemyManager.CreatEnemy(BattleManager.mPathList ,"Warrior");

        BattleManager.InitData(MapsManager.GetPath("1"), enemyAmout);

    }
    public override void OnEnter()
    {
        base.OnEnter();
    }
    public override void OnExit()
    {
        base.OnExit();
    }
    public override void OnButtonClick(string name, GameObject gameObject)
    {
        base.OnButtonClick(name, gameObject);
    }

    public override void OnNodeAsset(string name, GameObject gameObject)
    {
        base.OnNodeAsset(name, gameObject);
    }
}
