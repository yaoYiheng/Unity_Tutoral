using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

[CustomEditor(typeof(Map))]
public class MapEditor : Editor
{
    [HideInInspector]
    public Map mMap;

    //存储文件列表
    List<FileInfo> fileList = new List<FileInfo>();

    //当前正在编辑的索引
    int mSelectedIndex = 0;

    public override void OnInspectorGUI()
    {

        mMap = target as Map;

        base.OnInspectorGUI();

        if(Application.isPlaying)
        {
            EditorGUILayout.BeginHorizontal();

            int currentIndex = EditorGUILayout.Popup(mSelectedIndex, GetFileNames(fileList));
            if (currentIndex != mSelectedIndex)
            {
                mSelectedIndex = currentIndex;
                LoadLevel();
            }
            //下拉菜单


            if (GUILayout.Button("读取列表"))
            {

                //读取关卡列表
                LoadLevelFiels();
            }
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button("清除塔位"))
            {
                mMap.ClearGrid();
            }

            if (GUILayout.Button("清除路径"))
            {
                mMap.ClearPath();
            }
            EditorGUILayout.EndHorizontal();

            if (GUILayout.Button("保存"))
            {
                SaveLevel();
            }
        }

        if (GUI.changed)
            EditorUtility.SetDirty(target);

    }

    //将列表中的文件转换成 数组返回
    string[] GetFileNames(List<FileInfo> files)
    {
        List<string> fileName = new List<string>();
        foreach(FileInfo file in files)
        {
            fileName.Add(file.Name);
        }
        return fileName.ToArray();
    }


    //加载关卡列表
    void LoadLevelFiels()
    {

        //清除状态
        Clear();

        //加载列表
        //从文件夹读取文件, 得到fileInfo的列表保存到fileList当中
        //调用之前编写方法
        fileList = Tools.GetLevelFiels();
        if(fileList.Count > 0)
        {
            LoadLevel();
        }
    }

    void LoadLevel()
    {
        //通过下拉菜单得到的索引, 得到在文件列表中所对应的文件
        FileInfo file = fileList[mSelectedIndex];

        Level level = new Level();

        Tools.FillLevelFromFile(file.FullName, ref  level);

        mMap.LoadLevel(level);
    }

    void SaveLevel()
    {
        //获取到当前的Map上的Level信息
        Level level = mMap.Level;

        List<Point> temp = null;
        temp = new List<Point>();
        foreach(GridInfo grid in mMap.Grids)
        {
            if(grid.CanHold)
            {
                Point point = new Point(grid.X, grid.Y);
                temp.Add(point);
            }
        }
        level.WeaponPos = temp;

        temp = new List<Point>();
        foreach (GridInfo grid in mMap.Road)
        {

            Point point = new Point(grid.X, grid.Y);
            temp.Add(point);

        }

        level.Path = temp;

        //通过索引获取当前编辑的文件名
        string fileName = fileList[mSelectedIndex].FullName;

        //写入到文件
        //Tools.WriteLevelToFile(fileName, level);

        //提示框
        EditorUtility.DisplayDialog("保存关卡数据", "保存成功", "确定");

    }

    void Clear()
    {
        fileList.Clear();
        mSelectedIndex = 0;
    }
}
