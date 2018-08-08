using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsTest : MonoBehaviour {


    public float value = 5;
    Vector3 offset;

    public float current;
    public float max;
    public float delta;
	// Use this for initialization
	void Start () {

        offset = new Vector3(
            Random.Range(-value, value),
            Random.Range(-value, value),
            Random.Range(-value, value)
        );
	}
	
	// Update is called once per frame
	void Update () {

        //Test1();
        Test2();
	}

    void Test1()
    {
        if (Input.GetMouseButton(0))
        {
            current -= 1;

        }

        current = Mathf.MoveTowards(current, max, delta * Time.deltaTime);
        transform.localScale = new Vector3(1, current, 1);
    }

    void Test2()
    {

        float r = Mathf.PerlinNoise(Time.time, offset.x);
        float g = Mathf.PerlinNoise(Time.time, offset.y);
        float b = Mathf.PerlinNoise(Time.time, offset.z);
        Camera.main.backgroundColor = new Color(r, g, b);
    }
}
