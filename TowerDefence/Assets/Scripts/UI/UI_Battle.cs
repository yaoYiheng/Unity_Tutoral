using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Battle : UILayer 
{
    public Text lifeText;

    private int enemyAmout = 10;

    private void Update()
    {
        BattleManager.BattleUpdate();
    }
    public void RefreshLife ()
    {
        lifeText.text = string.Format("剩余生命值: {0}", BattleManager.m_HomeLife);
    }
    public override void OnNodeLoad()
    {
        MapsManager.m_MapObj.transform.localPosition = Vector3.zero;
        //BattleManager.mPathList = MapsManager.GetPath("1");

        ////创建怪物
        //Enemy enemy_obj = EnemyManager.CreatEnemy(BattleManager.mPathList ,"Warrior");

        BattleManager.InitData(this, MapsManager.GetPath("1"), enemyAmout);

        //刷新生命
        RefreshLife();


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
        switch(name)
        {
            case "Life_Text":
                lifeText = gameObject.GetComponent<Text>();
                break;
                
        }
    }
}
