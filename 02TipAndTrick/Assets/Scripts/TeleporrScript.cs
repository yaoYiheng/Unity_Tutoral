using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporrScript : MonoBehaviour {


    private void OnEnable()
    {
        EventManger.onClick += OnChange;
    }

    private void OnDisable()
    {
        EventManger.onClick -= OnChange;
    }

    void OnChange()
    {
        Vector3 currentPos = transform.position;
        currentPos.x = Random.Range(1f, 3f);
        currentPos.y = Random.Range(1f, 3f);
        currentPos.z = Random.Range(1f, 3f);
        transform.position = currentPos;
    }

}
