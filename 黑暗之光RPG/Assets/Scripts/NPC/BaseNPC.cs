using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNPC : MonoBehaviour 
{

    private void OnMouseEnter()
    {
        MouseController._instance.SetCurseTalk();

    }


    private void OnMouseExit()
    {
        MouseController._instance.SetCurseNormal();
    }
}
