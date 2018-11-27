using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    #region 常量
    //行数与列数
    public const int RowCount = 8;
    public const int ColumnCount = 12;
    #endregion


    #region 事件
    #endregion


    #region 字段
    //地图宽高 单位为米
    float MapWidth;
    float MapHeight;

    //格子宽高
    float GridWidth;
    float GridHeight;

    // 为了帮助地图, 会动态绘制格子线. 在实际运行的时候格子会取消.用这个变量进行控制
    //是否绘制网格
    public bool DrawGizmos = true;

    List<GridInfo> GridList = new List<GridInfo>();
    List<GridInfo> Road = new List<GridInfo>(); 

    #endregion


    #region 属性
    #endregion


    #region 方法
    #endregion

    #region Unity生命周期 回调
    #endregion

    #region 事件回调
    #endregion


    #region 帮助方法 
    //计算地图宽高与格子宽高
    void CalculateSize()
    {
        //将屏幕宽度转换成为世界坐标, 在通过行列数得到格子的宽高

        //得到屏幕左下角的实际坐标
        Vector3 leftDown = Camera.main.ViewportToWorldPoint(new Vector3(0, 0));
        Vector3 rightUp = Camera.main.ViewportToWorldPoint(new Vector3(1, 1));

        //求得地图宽度
        MapWidth = rightUp.x - leftDown.x;
        MapHeight = rightUp.y - leftDown.y;

        //求得每个给子的宽高
        GridWidth = MapWidth / ColumnCount;
        GridHeight = MapHeight / RowCount;

    }

    //获取格子的世界坐标
    Vector3 GetGridPosition(GridInfo grid)
    {
        return (new Vector3(
            (-MapWidth / 2 + (grid.X + 0.5f) * GridWidth),
            (-MapHeight / 2) + (grid.Y + 0.5f) * GridHeight,
            0));
    }


    //根据格子索引号获得格子
    GridInfo GetGridByIndex(int x, int y)
    {
        //通过给的格子的索引, 计算格子在集合中的下标
        int index = x + y * ColumnCount;

        //对索引进行判断
        if(index < 0 || index >= GridList.Count)
        {
            return null;
        }

        return GridList[index];
    }



    //获得鼠标所在位置的世界坐标

    Vector3 GetWorldPosition()
    {
        //Camera.main.ScreenToWorldPoint

        Vector3 viewPortPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        Vector3 mouseWorldPos = Camera.main.ViewportToWorldPoint(viewPortPos);


        return mouseWorldPos;


    }

    //获得鼠标下的格子
    GridInfo GetGridUnderMouse()
    {
        Vector3 mousePos = GetWorldPosition();

        //根据鼠标在世界坐标的位置计算出对应的格子的x, y值

        int x = (int)((mousePos.x + MapWidth / 2) / GridWidth);
        int y = (int)((mousePos.y + MapHeight / 2) / GridHeight);

        return GetGridByIndex(x, y);
    }
    #endregion


}