using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour 
{

    private MeshRenderer meshFilter;

    //需要在脚本的开始与结束的是, 添加或是删除.
    private void OnEnable()
    {
        EventManger.onClick += OnColorChange;
    }
    private void OnDisable()
    {
        EventManger.onClick -= OnColorChange;
    }

    void OnColorChange()
    {

        //计算带有小数的随机数时, 需要有f出现.
        Color randomColor = new Color(Random.Range(0, 255) / 255f,
          Random.Range(0, 255) / 255f,
          Random.Range(0, 255) / 255f
        );

        //修改一个物体的颜色, 拿到MeshRenderer组件.
        // 修改组件下material下的color属性
        meshFilter.material.color = randomColor;
 
    }

    private void Start()
    {
        meshFilter = this.GetComponent<MeshRenderer>();
    }
}