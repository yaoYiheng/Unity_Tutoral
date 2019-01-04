using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ReusableObejct : MonoBehaviour, IReusable
 {
	 public abstract void OnSpawn();

	 public abstract void UnSpawn();

}
