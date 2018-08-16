using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MapsManager
{
    public static GameObject m_MapObj;
    private const string filePath = "Maps/";
    private const string m_MapBoxPath = "Model/map_box";
    public static List<GameObject> m_MapBoxObj = new List<GameObject>();


    public static List<Vector3> GetPath(string mapName)
    {
        //从资源文件夹中获取之前保存的地图文件
        TextAsset textAsset = Resources.Load<TextAsset>(filePath + mapName);

        //将从获取到的文件转换成string
        string text = textAsset.text;

        //对该文件进行切分
        //TrimEnd, 似乎是用来删去最后的空格
        //Split()以指定的字符串作为切割符, 返回一个数值
        string[] pos_Str = text.TrimEnd('\n').Split('\n');

        List<Vector3> list = new List<Vector3>();
        string[] pos_xz;
        for (int i = 0; i < pos_Str.Length;i++)
        {
            //Debug.Log(pos_Str[i]);
            pos_xz = pos_Str[i].Split(',');
            //将单个的一组坐标的x,z值放入一个数组中. 再将x, z值组成一个v3并加入到List
            //int.Parse()将字符串所表示的数值转换成int类型的数
            if(pos_xz.Length == 2)
            {
                list.Add(new Vector3(int.Parse(pos_xz[0]), 0, int.Parse(pos_xz[1])));
            }

        }

        for (int i = 0; i < m_MapBoxObj.Count; i++)
        {
            GameObject.Destroy(m_MapBoxObj[i]);
        }

        if(list.Count > 0)
        {
            GameObject box_obj = Resources.Load<GameObject>(m_MapBoxPath);
            Vector3 pos = list[0];
            box_obj = GameObject.Instantiate(box_obj);
            box_obj.transform.localPosition = pos;
            m_MapBoxObj.Add(box_obj);
            for (int i = 1; i < list.Count;i++)
            {
                while(pos.x > list[i].x)
                {
                    pos.x--;
                    box_obj = GameObject.Instantiate(box_obj);
                    box_obj.transform.localPosition = pos;
                    m_MapBoxObj.Add(box_obj);
                }
                while (pos.x < list[i].x)
                {
                    pos.x++;
                    box_obj = GameObject.Instantiate(box_obj);
                    box_obj.transform.localPosition = pos;
                    m_MapBoxObj.Add(box_obj);
                }
                while (pos.z > list[i].z)
                {
                    pos.z--;
                    box_obj = GameObject.Instantiate(box_obj);
                    box_obj.transform.localPosition = pos;
                    m_MapBoxObj.Add(box_obj);
                }
                while (pos.z < list[i].z)
                {
                    pos.z++;
                    box_obj = GameObject.Instantiate(box_obj);
                    box_obj.transform.localPosition = pos;
                    m_MapBoxObj.Add(box_obj);
                }
            }
        }

        return list;


    }



}
