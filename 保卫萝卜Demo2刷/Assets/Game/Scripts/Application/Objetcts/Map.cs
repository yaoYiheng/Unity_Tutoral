using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GridClickEventArgs: EventArgs
{
    public int MouseDown;
    public GridInfo GridInfo;

    public GridClickEventArgs(int id, GridInfo grid)
    {
        this.MouseDown = id;
        this.GridInfo = grid;
    }
}

//描述一个地图关卡的状态
public class Map : MonoBehaviour 
{


	#region 常量
	public const int RowCount = 8;
	public const int ColoumCount =12;
    #endregion

    #region 事件
    public event EventHandler<GridClickEventArgs> OnGridClick;
	#endregion

	#region 字段
	//地图宽高
	float m_MapWidth;
	float m_MapHeight;

	//格子宽高
	float m_GridWidth;
	float m_GridHeight;

	//持有关卡的引用
	Level m_Level;
	//是否绘制
    public bool DrawGizmos = true;

	//场景中所有格子的集合
    List<GridInfo> m_GridsList = new List<GridInfo>();
	// 路径的集合
    List<GridInfo> m_PathesList = new List<GridInfo>();


    #endregion

    #region 属性
    public Level Level { get { return m_Level; } }
    public List<GridInfo> GridsList { get { return m_GridsList; }}
    public List<GridInfo> PathsList { get { return m_PathesList; }}
    //获得怪物行走路径的世界坐标的集合
    public Vector3[] MonsterPath 
    {
        get
        {
            List<Vector3> temp = new List<Vector3>();

            for (int i = 0; i < PathsList.Count; i++)
            {
                Vector3 temoPos = GetGridPosition(PathsList[i]);
                temp.Add(temoPos);
            }

            return temp.ToArray();
        }
    }

    //将设置背景图片的属性封装起来, 只要给出图片的路径, 就能够设置图
    public string BackgroundImage
    {
        set
        {
            //获取到要设置图片的组件
            SpriteRenderer temp = transform.Find("Background").GetComponent<SpriteRenderer>();
            StartCoroutine(Tools.LoadImage(value, temp));
        }
    }

    public string RoadImage
    {
        set
        {
            SpriteRenderer temp = transform.Find("Route").GetComponent<SpriteRenderer>();
            StartCoroutine(Tools.LoadImage(value, temp));
        }
    }
    #endregion

    #region 方法
    public void LoadLevel(Level level)
    {
        ClearAll();

        m_Level = level;

        //根据传入的level设置
        this.BackgroundImage = "file://" + Consts.MapPath + level.Background;
        this.RoadImage = "file://" + Consts.MapPath + level.Road;

        // 将level中的路径点转换成grid然后保存到路径列表当中
        foreach (var item in level.MonsterRoute)
        {
            GridInfo tempGrid = GetGridByIndex(item.X, item.Y);
            m_PathesList.Add(tempGrid);
        }

        foreach (var item in level.WeaponPos)
        {
            GridInfo gridInfo = GetGridByIndex(item.X, item.Y);
            gridInfo.CanHold = true;
        }


    }
    // 清除全部
    public void ClearAll()
    {
        m_Level = null;
        ClearPath();
        ClearWeapon();
    }

    //清除路径信息
    public void ClearPath()
    {
        m_PathesList.Clear();
    }

    // 清除塔位信息
    public void ClearWeapon()
    {
        foreach (var item in m_GridsList)
        {
            if (item.CanHold)
            {
                item.CanHold = false;
            }
        }
    }
    #endregion

    #region Unity回调
    void OnDrawGizmos()
	{
        if (!DrawGizmos) return;


        //计算
        Calculate();


        // 绘制网格
        Gizmos.color = Color.green;

        for (int row = 0; row <= RowCount ; row++)
        {
            Vector2 from = new Vector2(-m_MapWidth / 2, -m_MapHeight / 2 + row * m_GridHeight);
            Vector2 to = new Vector2(-m_MapWidth /2 + m_MapWidth, -m_MapHeight / 2 + row * m_GridHeight);
            Gizmos.DrawLine(from, to);
        }

        for (int col = 0; col <= ColoumCount; col++)
        {
            Vector2 from = new Vector2(-m_MapWidth / 2 + col * m_GridWidth, m_MapHeight / 2);
            Vector2 to = new Vector2(-m_MapWidth / 2 + col * m_GridWidth, -m_MapHeight / 2);
            Gizmos.DrawLine(from, to);
        }


        //绘制炮塔点
        foreach (var item in m_GridsList)
        {
            if (item.CanHold)
            {
                Vector3 tempPos = GetGridPosition(item);

                Gizmos.DrawIcon(tempPos, "holder.png", true);
            }
        }

        //绘制起止点以及行走路线
        for (int i = 0; i < m_PathesList.Count; i++)
        {
            // 绘制起点图标
            if(i == 0)
            {
                Gizmos.DrawIcon(GetGridPosition(m_PathesList[i]), "start.png", true);
            }
            // 绘制终点
            if (m_PathesList.Count > 1 && i == m_PathesList.Count - 1)
            {
                Gizmos.DrawIcon(GetGridPosition(m_PathesList[i]), "end.png", true);
            }

            //红线
            Gizmos.color = Color.red;
            if (m_PathesList.Count > 1 && i != 0)
            {
                Vector3 from = GetGridPosition(m_PathesList[i]);
                Vector3 to = GetGridPosition(m_PathesList[i - 1]);

                Gizmos.DrawLine(from, to);
            }
        }


    }
	void Awake()
	{
        Calculate();

        //创建所有的格子, 并加载到列表当中
        for (int i = 0; i < RowCount; i++)
        {
            for (int j = 0; j < ColoumCount; j++)
            {
                m_GridsList.Add(new GridInfo(j, i));
            }
        }

        OnGridClick += Map_OnGridClick;
    }

    private void Update()
    {

        //点击鼠标左键
        if (Input.GetMouseButtonDown(0))
        {
            //获取到鼠标下的格子
            GridInfo grid = GetGridByPosition(GetMousePosition());
            if (OnGridClick != null)
            {
                OnGridClick(this, new GridClickEventArgs(0, grid));
            }
        }

        //点击鼠标左键
        if (Input.GetMouseButtonDown(1))
        {
            //获取到鼠标下的格子
            GridInfo grid = GetGridByPosition(GetMousePosition());
            if (OnGridClick != null)
            {
                OnGridClick(this, new GridClickEventArgs(1, grid));
            }
        }
    }
    #endregion

    #region 事件回调

    void Map_OnGridClick(object sender, GridClickEventArgs e)
    {
        if (Level == null)
        {
            return;
        }


        // 根据点击事件处理放置炮塔
        if (e.MouseDown == 0 && !m_PathesList.Contains(e.GridInfo))
        {
            e.GridInfo.CanHold = !e.GridInfo.CanHold;
        }

        //鼠标点击的是右键, 且被点击的格子不是用于放置炮塔
        if (e.MouseDown == 1 && !e.GridInfo.CanHold)
        {
            //如果被点击的点存在于路径数组中, 就将其移除, 反之则添加
            if (m_PathesList.Contains(e.GridInfo))
            {
                m_PathesList.Remove(e.GridInfo);
            }
            else
            {
                m_PathesList.Add(e.GridInfo);
            }
        }
    }


    #endregion

    #region 帮助方法
    //计算地图与格子的大小
    void Calculate()
	{
		//获取到视口坐标左上角与右下角对应的世界坐标
		Vector3 leftDown = Camera.main.ViewportToWorldPoint(new Vector3(0, 0));
		Vector3 rightUp = Camera.main.ViewportToWorldPoint(new Vector3(1, 1));

		//求得地图的宽高
		m_MapWidth = Mathf.Abs(rightUp.x - leftDown.x);
		m_MapHeight = Mathf.Abs(rightUp.y - leftDown.y);

		//同地图宽高求得格子宽高
		m_GridHeight = m_MapHeight / RowCount;
		m_GridWidth = m_MapWidth / ColoumCount;
		
	}

	//获得格子中心所在的世界坐标
	public Vector3 GetGridPosition(GridInfo grid)
	{
		return new Vector3(
			-m_MapWidth / 2 + (grid.X + 0.5f) * m_GridWidth,
			-m_MapHeight / 2 + (grid.Y + 0.5f) * m_GridHeight,
			0
		);
	}

	//通过索引获取格子
	public GridInfo GetGridByIndex(int gridX, int gridY)
	{
		//计算index
		int index = gridX + gridY * ColoumCount;

        print(index);
		//判断index是否越界
		if(index < 0 || index >= m_GridsList.Count - 1)
        {
            throw new IndexOutOfRangeException("格子索引越界");

        }
		
        return m_GridsList[index];

	}

	// 获得鼠标下的世界坐标

    public Vector3 GetMousePosition()
    {
        //先将屏幕上的坐标转换成视口坐标
        Vector3 position = Camera.main.ScreenToViewportPoint(Input.mousePosition);

        //再将视口坐标转换成鼠标所在的世界坐标
        Vector3 mousePosition = Camera.main.ViewportToWorldPoint(position);

        print(mousePosition.x);
        print(mousePosition.y);
        return mousePosition;
    }


	// 通过给出的世界坐标得到对应的格子
    public GridInfo GetGridByPosition(Vector3 position)
    {
        int gridX = (int)((m_MapWidth / 2 + position.x) / m_GridWidth);
        int gridY = (int)((m_MapHeight / 2 + position.y) / m_GridHeight);

        return GetGridByIndex(gridX, gridY);
        
    }
	#endregion
}
