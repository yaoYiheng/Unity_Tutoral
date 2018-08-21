using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoCreatItem : MonoBehaviour {

    public GameObject itemPrefab;

    public int count;
	// Use this for initialization
	void Start () {

        for (int i = 0; i < count; i++)
        {
            GameObject item = Instantiate(itemPrefab);
            //需要将该item的transform转换成RectTransform
            RectTransform itemTransform = item.transform as RectTransform;
            //设置到parent上
            itemTransform.SetParent(transform);
            item.transform.position = Vector3.zero;
            item.transform.localScale = Vector3.one;
            item.transform.rotation = Quaternion.Euler(Vector3.zero);    
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
