using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    //关卡名字
    public string Name;

    public string CardImage;

    //背景
    public string Background;

    //行走路径
    public string Road;

    //初始金币
    public int InitGold;

    //炮塔可放置的位置
    public List<Point> WeaponPos = new List<Point>();

    //怪物行走路径
    public List<Point> Path = new List<Point>();

    //出怪回合数
    public List<Round> Rounds = new List<Round>();

     
}
