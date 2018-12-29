using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ReusableObject : MonoBehaviour, IReuseable
{
    public  abstract void OnSpawn();

    public abstract void UnSpawn();



}
