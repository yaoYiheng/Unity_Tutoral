using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellTowerCommand : Controller
{
    public override void Excute(object data)
    {
        SellTowerArgs sellTowerArgs = data as SellTowerArgs;
        Tower tower = sellTowerArgs.Tower;


        //卖出塔回收金币
        GameModel gameModel = GetModel<GameModel>();
        gameModel.Gold += (tower.BasePrice / 2);

        //清除塔位信息
        tower.GridInfo.data = null;

        Game.Instance.ObjectPool.UnSpawn(tower.gameObject);
    }
}
