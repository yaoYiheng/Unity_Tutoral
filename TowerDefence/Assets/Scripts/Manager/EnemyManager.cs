using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager :MonoBehaviour
{

    public const string EnemyPath = "Model/Role/";

    public static Enemy CreatEnemy(List<Vector3> mPathList, string model_name)
    {
        GameObject obj = Resources.Load<GameObject>(EnemyPath + model_name);

        GameObject enemyObj = Instantiate(obj) as GameObject;
        //生成敌人的对象后, 直接给其添加Enemy脚本, 并返回
        Enemy enemy = enemyObj.AddComponent<Enemy>();
        enemy.InitData(mPathList);
        return enemy;
            
    }
}
