using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPath : MonoBehaviour 
{
    public List<Vector3> m_MapList = new List<Vector3>();
    public float m_MaxZoomSize = 12f;
    public float m_MinZoomSize = 6f;

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
        Gizmos.color = Color.white;
        //第一个点的坐标的
        int _x, _z;
        for (int i = 1; i < m_MapList.Count;i++)
        {
            _x = (int)m_MapList[i - 1].x;
            _z = (int)m_MapList[i - 1].z;
             //实现的目标是有第一个点向第二个点的方向绘制
            //如果第一个点的x值大于第二个点的x, 说明第一个点在第二个点的右边,
            //绘制需要每次减小x的值. 
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
        }
        Gizmos.color = Color.yellow;
        //绘制最后一个点的颜色为黄色
        //列表的最后一个点 == mapList[列表长度 - 1]所表示的那个点.
        if(m_MapList.Count > 0)
        {
            Gizmos.DrawCube(m_MapList[m_MapList.Count - 1], new Vector3(0.95f, 0.95f, 0.95f));
        }

    }

    private void Update()
    {
        //实现通过鼠标点击绘制地图
        //接受输入
        if (Input.GetMouseButtonDown(0))//点击左键
        {
            //将鼠标所点击的位置换成世界坐标
            Vector3 mousePos = Input.mousePosition;
            //因为摄像机距离地面有10的距离, 需要设置到z轴上
            //Z的位置是以世界单位衡量的到相机的距离
            mousePos.z = 10;
            //将摄像机的屏幕坐标转换成世界坐标
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            //将坐标进行整数化, 
            //Mathf.Round  可以将浮点数转换成离它最近的整数
            mousePos.x = Mathf.Round(mousePos.x);
            mousePos.z = Mathf.Round(mousePos.z);

            //将该点添加到列表中
            m_MapList.Add(mousePos);
        }

        //实现右键点击, 撤销上一步操作
        if(Input.GetMouseButtonDown(1))
        {
            if(m_MapList.Count > 0)
            {
                m_MapList.RemoveAt(m_MapList.Count - 1);
            }
        }

        if(Input.GetAxis("Mouse ScrollWheel") > 0)//向下滑动鼠标滚轮时, 大于0, 视野变小
        {
            //向下滚动时, zoomin
            if(Camera.main.orthographicSize * 0.9  < m_MinZoomSize)
            {
                Camera.main.orthographicSize = m_MinZoomSize;
            }
            else
            {
                Camera.main.orthographicSize *= 0.9f;
            }

        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)//向上滑动鼠标滚轮时, 小于0, 视野变大
        {
            //向下滚动时, zoomin
            if (Camera.main.orthographicSize * 1.1 > m_MaxZoomSize)
            {
                Camera.main.orthographicSize = m_MaxZoomSize;
            }
            else
            {
                Camera.main.orthographicSize *= 1.1f;
            }
        }
    }
}
