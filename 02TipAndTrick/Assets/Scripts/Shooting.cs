using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public Transform firpos;
    public Rigidbody shell;
    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
    private void Fire()
    {
        Rigidbody shellIns = Instantiate(shell, firpos.position, shell.rotation) as Rigidbody;

        //Vector3 fire = firpos.forward * speed;
        shellIns.AddForce(firpos.forward * speed);

    }
}
