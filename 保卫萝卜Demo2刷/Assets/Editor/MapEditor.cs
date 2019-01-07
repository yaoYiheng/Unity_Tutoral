using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Map))]
public class MapEditor : Editor 
{
    [HideInInspector]
    public Map Map = null;

    int m_SelectIndex = -1;
    List<FileInfo> m_FileList = new List<FileInfo>();

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Map = target as Map;

        if (Application.isPlaying)
        {
            EditorGUILayout.BeginVertical(GUI.skin.box);
            //EditorGUI.indentLevel++;
            EditorGUILayout.BeginHorizontal();

            int currentIndex = EditorGUILayout.Popup(m_SelectIndex, GetFilesName(m_FileList));
            if (currentIndex != m_SelectIndex)
            {
                //更新当前正在编辑的关卡索引
                m_SelectIndex = currentIndex;

                LoadLevel();
            }

            if(GUILayout.Button("读取列表"))
            {
                LoadLevelFiles();
            }


            EditorGUILayout.EndHorizontal();

       
            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button("清除塔点"))
            {
                Map.ClearWeapon();
            }
            if (GUILayout.Button("清除路径"))
            {
                Map.ClearPath();
            }

            EditorGUILayout.EndHorizontal();


            //EditorGUILayout.BeginHorizontal();

            //if (GUILayout.Button("读取列表"))
            //{
            //    LoadLevelFiles();
            //}


            //EditorGUILayout.EndHorizontal();


            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("清除全部"))
            {
                Map.ClearAll();
            }
            if (GUILayout.Button("保存数据"))
            {
                SaveLevel();
            }


            EditorGUILayout.EndHorizontal();

            //EditorGUI.indentLevel--;
            EditorGUILayout.EndVertical();
        }
    }

    void SaveLevel()
    {
        //获取当前正在编辑的level
        Level level = Map.Level;


        List<Point> tempList = null;

        tempList = new List<Point>();
        // 将当前地图上的炮塔点 更新到level类中的可放置炮塔点
        for (int i = 0; i < Map.GridsList.Count; i++)
        {
            GridInfo grid = Map.GridsList[i];

            if (grid.CanHold)
            {
                Point point = new Point(grid.X, grid.Y);
                tempList.Add(point);
            }
        }

        level.WeaponPos = tempList;

        //清零临时list


        tempList = new List<Point>();
        for (int i = 0; i < Map.PathsList.Count; i++)
        {
            //将在地图上的路径点放置到list中
            GridInfo grid = Map.PathsList[i];

            Point point = new Point(grid.X, grid.Y);
            tempList.Add(point);
        }
        level.MonsterRoute = tempList;


        //获取到当前正在编辑的level的文件名
        string fileName = m_FileList[m_SelectIndex].FullName;

        //保存至本地
        Tools.SaveLevel(fileName, level);

        //弹框提示
        EditorUtility.DisplayDialog("保存关卡数据", "保存成功", "确定");

    }
    void LoadLevelFiles()
    {
        Clear();
        //从本地获取文件list
        m_FileList = Tools.GetLevelFiels();

        if (m_FileList.Count > 0)
        {
            m_SelectIndex = 0;
            LoadLevel();
        }
    }
    void LoadLevel()
    {
        //根据当前编辑的关卡的索引, 从文件中获取到指定的level文件
        FileInfo file = m_FileList[m_SelectIndex];

        Level level = new Level();
        //从工具类中, 调用通过文件名获取到level类对象的方法
        Tools.FillLevel(file.FullName, ref level);

        //获取到level后加载到地图中
        Map.LoadLevel(level);

    }
    //获取List<FileInfo>中的文件名数组
    string[] GetFilesName(List<FileInfo> fileList)
    {
        List<string> temp = new List<string>();

        foreach (var file in fileList)
        {
            temp.Add(file.Name);
        }
        return temp.ToArray();
    }

    void Clear()
    {
        m_FileList.Clear();
        //m_SelectIndex = -1;
    }
}
