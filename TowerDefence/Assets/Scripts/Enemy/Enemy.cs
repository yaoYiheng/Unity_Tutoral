﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    //前行的坐标
    public List<Vector3> m_EnemyPath = new List<Vector3>();
    public float m_MoveSpeed = 1f;

    private float lifeTime = 1f;

    public void InitData(List<Vector3> path){
        m_EnemyPath.AddRange(path);
        if(m_EnemyPath.Count >0)
        {
            transform.localPosition = m_EnemyPath[0];
            //将角色设置到第一个点之后, 就可以将该点移除掉
            m_EnemyPath.RemoveAt(0);
        }
    }
	// Use this for initialization
	void Start () {
		
	}

    private void Update()
    {
        //如果有当前点
        if(m_EnemyPath.Count > 0)
        {
            Vector3 pos = m_EnemyPath[0];
            //如果当前角色位置与下一个点处在同一水平面(即x值相同)
            //则开始z轴上的行动, 否则就是x轴上的
            float distance;
            if(this.transform.localPosition.x == pos.x)
            {
                distance = Mathf.Abs(transform.localPosition.z - pos.z);

            }
            else
            {
                pos.z = transform.localPosition.z;
                distance = Mathf.Abs(transform.localPosition.x - pos.x);

                
            }
            float time = distance / m_MoveSpeed;
            if (Time.deltaTime >= time) 
            {
                transform.localPosition = pos;
                //如果已经到达目标点, 则删除当前点.
                if(transform.localPosition == m_EnemyPath[0])
                {
                    m_EnemyPath.RemoveAt(0);
                }
            }
            else
            {
                transform.localPosition = Vector3.Lerp(transform.localPosition, pos, Time.deltaTime / time);
            }
        }
        else//敌人走到终点就删除
        {
            //DestroyObj();
        }
    }

    public void DestroyObj()
    {
        Destroy(gameObject, lifeTime);
    }
}
