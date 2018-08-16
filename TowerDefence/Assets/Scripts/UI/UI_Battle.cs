using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Battle : UILayer 
{
    //用于保存地图路径
    public List<Vector3> mPathList;

    public override void OnNodeLoad()
    {
        MapsManager.m_MapObj.transform.localPosition = Vector3.zero;
        mPathList = MapsManager.GetPath("1");

        //创建怪物
        GameObject enemy_obj = EnemyManager.CreatEnemy("Warrior");

        Enemy enemy = enemy_obj.AddComponent<Enemy>();
        enemy.InitData(mPathList);
         

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
