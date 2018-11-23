using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestUI : MonoBehaviour {

    public static QuestUI _instace;

    private bool isShow = false;
    private Animator animator;

    private void Awake()
    {

        _instace = this;


    }
    // Use this for initialization
    void Start () 
    {

        animator = GetComponent<Animator>();
        print(animator);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DisplayQuest()
    {
        if (isShow == false)
        {
            //开始播放动画
            animator.Play("QuestAnimation");

            this.enabled = true;
            isShow = true;
        }
        else
        {
            animator.StartPlayback();
            this.enabled = false;
            //反向
            isShow = false;
        }
    }
}
