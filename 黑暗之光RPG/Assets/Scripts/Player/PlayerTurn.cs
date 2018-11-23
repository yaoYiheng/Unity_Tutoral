using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : MonoBehaviour {


    private bool isPressed = false;
    private PlayerMove PlayerMove;
    public Vector3 targetPosition;
	// Use this for initialization
	void Start () 
    {
        targetPosition = transform.position;
        PlayerMove = GetComponent<PlayerMove>();
	}

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit raycastHit;

        if (Input.GetMouseButtonDown(0))
        {
            isPressed = true;


        }

        if (Input.GetMouseButtonUp(0))
        {
            isPressed = false;
        }


        if (Input.GetMouseButton(0) && (Physics.Raycast(ray, out raycastHit)))
        {
            print(raycastHit.collider.tag); 

            if (raycastHit.collider.tag == Tags.NPC)
            {
                PlayerMove.playerMovementStates = PlayerMovementStates.Idle;
                transform.LookAt(raycastHit.point);
                transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);

                return;
            }

            else
            {
                targetPosition = raycastHit.point;
                transform.LookAt(raycastHit.point);

                transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);
  
            }
        }



    }
}
