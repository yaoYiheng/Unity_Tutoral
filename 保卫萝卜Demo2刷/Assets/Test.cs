using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {

    Image m_Image;

    private void Start()
    {
        m_Image = GetComponent<Image>();

        var sprites = Resources.LoadAll<Sprite>("Res/Roles/Fan/MainTown");
        m_Image.sprite = sprites[44];
    }
}
