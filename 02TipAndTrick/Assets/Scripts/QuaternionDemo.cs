using UnityEngine;
using System.Collections;

public class QuaternionDemo : MonoBehaviour
{
    public Transform target;
    public float speed;

    void Update()
    {
        Vector3 relativePos = target.position + new Vector3(0, 5, 0)  - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        transform.Translate( 0,0,Time.deltaTime);
    }
}
