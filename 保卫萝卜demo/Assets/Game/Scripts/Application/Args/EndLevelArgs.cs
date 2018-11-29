using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelArgs 
{
    //从那一关离开.
    public int LevelIndex { set; get; }

    public bool IsSuccessed;// 是否成功完成一局
}