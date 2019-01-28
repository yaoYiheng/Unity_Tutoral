using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTowerCommand : Controller
{
    public override void Excute(object data)
    {
        //拿到塔
        UpgradeToweArgs upgradeToweArgs = data as UpgradeToweArgs;
        Tower tower = upgradeToweArgs.Tower;
        GameModel gameModel = GetModel<GameModel>();
        gameModel.Gold -= tower.Price;
        tower.Level++;

    }
}
