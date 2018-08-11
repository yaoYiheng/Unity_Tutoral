using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour {


    [HideInInspector]public Rigidbody rig;
    public float damageRadius = 1;
    private void Reset()
    {
        rig = GetComponent<Rigidbody>();
    }
    [ContextMenu("Do Something")]
    void DoSomething()
    {
        Debug.Log("Perform operation");
    }

}
