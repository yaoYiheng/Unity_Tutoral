using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level 
{
	public string Name;
	public string CardImage;
	public string Background;
	public string Road;
	public int InitGold;
	//可放置武器位置列表
	public List<Point> WeaponPos = new List<Point>();

	//怪物行走路劲列表
	public List<Point> MonsterRoute = new List<Point>();

	//出怪回个信息列表
	public List<Round> Rounds = new List<Round>();

}