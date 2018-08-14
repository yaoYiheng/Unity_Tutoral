using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    
    private void Start()
    {
        //屏幕空间以像素定义，
        //屏幕左下为(0, 0)，右上是(pixelWidth, pixelHeight)，Z的位置是以世界单位衡量的到相机的距离。
        print(Camera.main.WorldToScreenPoint(gameObject.transform.position));
        print(gameObject.transform.localPosition);

    }
}
