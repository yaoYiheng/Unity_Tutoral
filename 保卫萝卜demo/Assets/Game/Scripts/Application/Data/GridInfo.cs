using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//存储格子信息
public class GridInfo 
{
    public int X;
    public int Y;
    public bool CanHold; //是否可以存放塔
    public object Data; //格子所存放的数据


    public GridInfo(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public override string ToString()
    {
        return string.Format("[x: {0}, y: {1}, canHold: {2}]",
                             this.X,
                             this.Y,
                             this.CanHold);
    }
}
