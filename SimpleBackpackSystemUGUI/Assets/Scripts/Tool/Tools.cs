using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Tools 
{
    public static IEnumerator LoadImage(string fileName, Image image)
    {
        WWW wWW = new WWW(fileName);
        while (!wWW.isDone)
        {
            yield return wWW;
        }

        Texture2D texture = wWW.texture;
        Sprite sprite = Sprite.Create(
            texture,
            new Rect(0, 0, texture.width, texture.height),
            new Vector2(0.5f, 0.5f));

        image.sprite = sprite;

    } 
    public static void GetMousePosition(out Vector2 position)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            GameObject.Find("KnapsackUI").transform as RectTransform,
            Input.mousePosition,
            null,
            out position
        );

    }
}
