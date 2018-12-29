using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower: Role
{
	#region 常量

#endregion

#region 事件

#endregion

#region 字段
int m_CurrentLevel;
#endregion

#region 属性

	public int TowerID{get; private set;}

	public int Price{get {return BasePrice * CurrentLevel;}}
	public int BasePrice{get; private set;}

	//当前等级
	public int CurrentLevel
	{	
		get{ return m_CurrentLevel;}
		set
		{	//对当前等级进行限制
			m_CurrentLevel = Mathf.Clamp(value, 0, MaxLevel);
			
			//根据当前等级设置大小
			transform.localScale = Vector3.one * (1 + CurrentLevel * 0.25f);
		}
	}
	public int MaxLevel{get; private set;}
	public bool IsMaxLevel
	{
		get {return CurrentLevel >= MaxLevel;}
	}

#endregion

#region 方法

#endregion

#region Unity回调

#endregion

#region 事件回调

#endregion

#region 帮助方法

#endregion
}