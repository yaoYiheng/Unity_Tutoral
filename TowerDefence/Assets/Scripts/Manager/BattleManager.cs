using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager 
{    //用于保存地图路径
    public static List<Vector3> mPathList;
    public static int BattleEnemyCount;
    private static float timer;

    public static void InitData (List<Vector3> vector3s, int enemyCount)
    {
        mPathList = vector3s;
        BattleEnemyCount = enemyCount;
        timer = 0f;
    }

    public static void BattleUpdate()
    {
        if(BattleEnemyCount > 0)
        {
            timer += Time.deltaTime;
            if(timer >= 1)
            {
                timer -= 1;
                EnemyManager.CreatEnemy(mPathList, "Warrior");
                BattleEnemyCount--;
            }
        }

    }
}
