using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerMovementStates
{
    Moving,
    Idle
}
public class PlayerMove : MonoBehaviour {



    private PlayerProperty playerProperty;
    private CharacterController characterController;
    private PlayerTurn playerTurn;

    public PlayerMovementStates playerMovementStates;
	// Use this for initialization
	void Start () 
    {
        characterController = GetComponent<CharacterController>();
        playerProperty = GetComponent<PlayerProperty>();
        playerTurn = GetComponent<PlayerTurn>();

	}
	
	// Update is called once per frame
	void Update ()
    {


        float distance = Vector3.Distance(transform.position, playerTurn.targetPosition);



        if(distance > 0.5f)
        {
            playerMovementStates = PlayerMovementStates.Moving;
            characterController.Move(transform.forward * Time.deltaTime * playerProperty.playerMoveSpeed);
        }
        else
        {
            playerMovementStates = PlayerMovementStates.Idle;
        }
	}
}
