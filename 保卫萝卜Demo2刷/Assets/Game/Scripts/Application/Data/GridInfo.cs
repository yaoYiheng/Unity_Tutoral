using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 格子信息类, 用于存储格子的位置以及格子是否能够放塔, 以及格子的信息
public class GridInfo
{
	public int X;
	public int Y; 
	public bool CanHold;
	public Object data;

	public GridInfo(int x, int y)
	{
		this.X = x;
		this.Y = y;
	}

	public override string ToString()
	{
		return string.Format("[X: {0}, Y: {1}, CanHold: {2}", this.X, this.Y, this.CanHold);
	}
}