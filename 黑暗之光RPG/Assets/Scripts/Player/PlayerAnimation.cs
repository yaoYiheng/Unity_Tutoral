using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {


    public string AnimationIdle;
    public string AnimationWalk;


    private Animation Animation;
    private PlayerMove PlayerMove;
	// Use this for initialization
	void Start () {

        PlayerMove = GetComponent<PlayerMove>();

        Animation = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(PlayerMove.playerMovementStates == PlayerMovementStates.Moving)
        {
            PlayAnimation(AnimationWalk);
        }
        else if(PlayerMove.playerMovementStates == PlayerMovementStates.Idle)
        {
            PlayAnimation(AnimationIdle);
        }
	}

    private void PlayAnimation(string animationName)
    {
        Animation.Play(animationName);
    }
}
