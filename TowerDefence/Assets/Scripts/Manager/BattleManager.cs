using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager 
{    //用于保存地图路径
    public static List<Vector3> mPathList;
    public static int BattleEnemyCount;
    private static float timer;
    public static int m_HomeLife;
    public static UI_Battle uI_Battle;
    public static List<Enemy> m_EnemyList = new List<Enemy>();
    public static bool m_IsStop = false;




    public static void InitData (UI_Battle uI_battle, List<Vector3> vector3s, int enemyCount)
    {
        mPathList = vector3s;
        BattleEnemyCount = enemyCount;
        m_HomeLife = 5;
        timer = 0f;
        for (int i = 0; i < m_EnemyList.Count;i++)
        {
            m_EnemyList[i].DestroyObj();
        }
        uI_Battle = uI_battle;
        m_IsStop = false;
    }

    public static void EnemyAttack()
    {
        if(BattleManager.m_HomeLife > 0)
        {
            m_HomeLife--;
            BattleManager.uI_Battle.RefreshLife();    
        }
        else
        {
            m_IsStop = true;
            Debug.Log("防守失败 ");
        }

    }
    public static void BattleUpdate()
    {
        if(m_IsStop == false)
        {
        
            if (BattleEnemyCount > 0)
            {
                timer += Time.deltaTime;
                if (timer >= 1)
                {
                    timer -= 1;
                    m_EnemyList.Add(EnemyManager.CreatEnemy(mPathList, "Warrior"));
                    BattleEnemyCount--;
                }
            }
            for (int i = m_EnemyList.Count - 1; i >= 0; i--)
            {
                if (m_EnemyList[i] == null)
                {
                    m_EnemyList.RemoveAt(i);
                }
                else
                {
                    m_EnemyList[i].BattleUpdate();
                }
            }
        }


    }
}
