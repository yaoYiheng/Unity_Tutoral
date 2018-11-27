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

    Level mLeve;

    // 为了帮助地图, 会动态绘制格子线. 在实际运行的时候格子会取消.用这个变量进行控制
    //是否绘制网格
    public bool DrawGizmos = true;

    List<GridInfo> mGridList = new List<GridInfo>();
    List<GridInfo> mRoad = new List<GridInfo>(); 

    #endregion


    #region 属性

    //获取地图所有格子集合
    public List<GridInfo> Grids
    {
        get { return mGridList; }
    }
    //获取所有能用于途径的格子的集合
    public List<GridInfo> Road
    {
        get { return mRoad; }
        
    }

    //将组成Road的格子转化成在世界坐标下的位置数组
    public Vector3[] Path
    {
        get
        {
            List<Vector3> tempList = new List<Vector3>();

            foreach(GridInfo grid in mRoad)
            {
                //调用 方法得到grid的
                Vector3 temp = GetGridPosition(grid);

                tempList.Add(temp);
                
            }

            return tempList.ToArray();
        }
    }
    //通过传入背景图片的路径, 就可以自动加载图片到对应的组件下显示
    public string BackgroundImage
    {
        set
        {
            //获取到需要设置图片的组件
            SpriteRenderer spriteRenderer = transform.Find("Background").GetComponent<SpriteRenderer>();
            StartCoroutine(Tools.LoadImage(value, spriteRenderer));
        }
    }

    public string RoadImage
    {
        set
        {
            SpriteRenderer spriteRenderer = transform.Find("Route").GetComponent<SpriteRenderer>();
            StartCoroutine(Tools.LoadImage(value, spriteRenderer));
        }
    }
    #endregion


    #region 方法

    //加载关卡的方法
    public void LoadLevel(Level level)
    {
        //无论当前什么状态, 先还原
        ClearAll();

        //保存属性
        this.mLeve = level;

        //设置 图片
        this.BackgroundImage = Const.MapPath + level.Background;
        this.RoadImage = Const.MapPath + level.Road;

        //寻路路径, 将level中保存的路径添加到地图的mRoad属性当中

        foreach(Point point in level.Path)
        {
            //将存储在level中的路径点索引, 转换成索引所对应的格子
            GridInfo grid = GetGridByIndex(point.X, point.Y);

            //将格子添加到Map类总用来保存路径的列表当中
            mRoad.Add(grid);
        }

        //炮塔空地, 将level中可以安放炮塔的属性改为true
        foreach(Point point in level.WeaponPos)
        {
            GridInfo grid = GetGridByIndex(point.X, point.Y);
            grid.CanHold = true;
        }


    }
    //清除塔位信息 
    public void ClearGrid()
    {
        //将可以放置炮塔的属性改为false
        foreach(GridInfo grid in mGridList)
        {
            if (grid.CanHold)
                grid.CanHold = false;
        }
    }
    //清除路径格子集合
    public void ClearPath()
    {
        //清除掉路径集合中的所有元素
        mRoad.Clear();
    }
    //清除所有信息
    public void ClearAll()
    {
        //将level置空
        mLeve = null;

        //调用清除方法

        ClearGrid();
        ClearPath(); 
    }
    #endregion

    #region Unity生命周期 回调

    private void Awake()
    {
        CalculateSize();

        for (int row = 0; row < RowCount; ++row)
            for (int col = 0; col < ColumnCount; ++col)
                mGridList.Add(new GridInfo(col, row));
                
    }
    //该回调函数只在编辑器里起作用
    private void OnDrawGizmos()
    {
        
        if (!DrawGizmos) return;

        //计算地图和格子大小
        CalculateSize();


        //开始绘制格子
        //设置格子 颜色为绿色
        Gizmos.color = Color.green;

        //从左向右
        //绘制行
        for (int row = 0; row <= RowCount;++ row)
        {
            Vector2 from = new Vector2(-MapWidth / 2, -MapHeight / 2 + row * GridHeight);
            Vector2 to = new Vector2(-MapWidth / 2 + MapWidth, -MapHeight / 2 + row * GridHeight);

            //绘制
            Gizmos.DrawLine(from, to);
        }

        //绘制列
        //从上向下
        for (int col = 0; col <= ColumnCount; ++ col)
        {
            Vector2 from = new Vector2(-MapWidth / 2 + col * GridWidth, MapHeight / 2);
            Vector2 to = new Vector2(-MapWidth / 2 + col * GridWidth, -MapHeight / 2);

            //绘制
            Gizmos.DrawLine(from, to);
            
        }

        //遍历所有格子, 查在可放置炮塔的位置绘制图标
        foreach(GridInfo grid in mGridList)
        {
            if(grid.CanHold)
            {

                Vector3 center = GetGridPosition(grid);
                //需要把这张图片放在Gizmos文件夹下
                Gizmos.DrawIcon(center, "holder.png", true);
            }
        }

        //根据怪物行进的点, 绘制出起点终点以及所经过的路径

        //使用红线
        Gizmos.color = Color.magenta;

        //print(Path.GetType());
        for (int i = 0; i < Path.Length; ++i)
        {
            //将第一个点绘制start
            if(i == 0)
            {
                //需要把这张图片放在Gizmos文件夹下
                Gizmos.DrawIcon(Path[i], "start.png", true);
            }

            //如果路径点的个数大于1, 并且i为数组中最后一个元素. 则绘制end图标
            if(Path.Length > 1 && i == (Path.Length - 1))
            {
                Gizmos.DrawIcon(Path[i], "end.png", true);
            }

            //如果数量大于1且索引不为0, 则在两点之间绘制一条线
            if(Path.Length > 1 && i != 0)
            {
                Vector3 from = Path[i - 1];
                Vector3 to = Path[i];

                Gizmos.DrawLine(from, to);

            }

        }
    }
    #endregion

    #region 事件回调
    #endregion


    #region 帮助方法 
    //计算地图宽高与格子宽高
    void CalculateSize()
    {
        //将屏幕宽度转换成为世界坐标, 在通过行列数得到格子的宽高

        //得到屏幕左下角的实际坐标
        Vector3 leftDown = new Vector3(0, 0);
        Vector3 rightUp = new Vector3(1, 1);

        Vector3 p1 = Camera.main.ViewportToWorldPoint(leftDown);
        Vector3 p2 = Camera.main.ViewportToWorldPoint(rightUp);

        //求得地图宽度
        MapWidth = Mathf.Abs(p2.x - p1.x);
        MapHeight = Mathf.Abs(p2.y - p1.y);

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
        if(index < 0 || index >= mGridList.Count)
        {
            return null;
        }

        return mGridList[index];
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