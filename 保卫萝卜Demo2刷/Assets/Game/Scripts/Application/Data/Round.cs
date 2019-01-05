using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round
{
	public int MonsterID;
	
	public int Count;

	public Round(int id, int count)
	{
		this.MonsterID = id;
		this.Count = count;
	}
}