using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarNPC : BaseNPC
{

    private Animator Animator;

    private void Awake()
    {

    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            QuestUI._instace.DisplayQuest();
        }

    }
}
