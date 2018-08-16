using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MapsManager
{
    public static GameObject m_MapObj;
    private const string filePath = "Maps/";


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
            list.Add(new Vector3(int.Parse(pos_xz[0]), 0, int.Parse(pos_xz[1])));

        }
        return list;
    }
}
