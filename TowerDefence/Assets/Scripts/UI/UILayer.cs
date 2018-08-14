using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILayer : MonoBehaviour
{
    /// 相关初始化
    private void Start()
    {
        this.__init_node(transform);

    }
    public void __init_node(Transform transform)
    {
        OnNodeAsset(transform.name, transform.gameObject);
        Button button = transform.GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(() =>
            {
                OnButtonClick(button.name, button.gameObject);
            });
        }
        for (int i = 0; i < transform.childCount; i++)
        {
            this.__init_node(transform.GetChild(i));
        }
    }

    public virtual void OnNodeAsset(string name, GameObject gameObject)
    {

    }

    public virtual void OnButtonClick(string name, GameObject gameObject)
    {

    }
}