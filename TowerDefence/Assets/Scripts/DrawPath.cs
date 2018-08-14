using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPath : MonoBehaviour 
{
    public List<Vector3> m_MapList = new List<Vector3>();

    private void Start()
    {
        m_MapList.Add(new Vector3(0, 0, 0));
        m_MapList.Add(new Vector3(0, 0, 10));
        m_MapList.Add(new Vector3(10, 0, 10));
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        if(m_MapList.Count > 0)
        {
            Gizmos.DrawCube(m_MapList[0], new Vector3(0.95f, 0.95f, 0.95f));
        }
        //Gizmos.color = Color.magenta;
        int _x, _z;
        for (int i = 1; i < m_MapList.Count;i++)
        {
            _x = (int)m_MapList[i - 1].x;
            _z = (int)m_MapList[i - 1].z;
            //实现的目标是有第一个点向第二个点的方向绘制
            //如果第一个点的x值大于第二个点的x, 说明第一个点在第二个点的右边,
            //绘制需要每次减小x的值. 

            while (_z > m_MapList[i].z)
            {
                _z--;
                Gizmos.DrawCube(new Vector3(_x, 0, _z), new Vector3(0.95f, 0.95f, 0.95f));
            }
            while (_z < m_MapList[i].z)
            {
                _z++;
                Gizmos.DrawCube(new Vector3(_x, 0, _z), new Vector3(0.95f, 0.95f, 0.95f));
            }
            while(_x > m_MapList[i].x)
            {
                _x--;
                Gizmos.DrawCube(new Vector3(_x, 0, _z), new Vector3(0.95f, 0.95f, 0.95f));
            }

            while (_x < m_MapList[i].x)
            {
                _x++;
                Gizmos.DrawCube(new Vector3(_x, 0, _z), new Vector3(0.95f, 0.95f, 0.95f));
            }

        }

    }
}
