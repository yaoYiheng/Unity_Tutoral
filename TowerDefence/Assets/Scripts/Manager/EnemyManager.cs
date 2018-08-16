using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager :MonoBehaviour
{

    public const string EnemyPath = "Model/Role/";
    public static GameObject CreatEnemy(string model_name)
    {
        GameObject obj = Resources.Load<GameObject>(EnemyPath + model_name);

        GameObject enemyObj = Instantiate(obj) as GameObject;


        return enemyObj;
            
    }
}
