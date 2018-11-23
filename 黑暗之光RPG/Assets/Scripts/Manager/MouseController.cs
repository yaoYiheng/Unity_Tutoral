using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseController : MonoBehaviour {


    public GameObject ClickEffectPrefab;

    public Texture2D NPCTalk;
    public Texture2D Normal;
    public static MouseController _instance;


    private Vector2 hotSpot;
    private CursorMode cursorMode;
    private void Awake()
    {
        _instance = this;
    }
    // Use this for initialization
    void Start () 
    {
        hotSpot = Vector2.zero;
        cursorMode = CursorMode.Auto;
	}
	
	// Update is called once per frame
	void Update () 
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit raycastHit;

        if(Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out raycastHit) && raycastHit.collider.tag == Tags.Ground)
            {
                Instantiate(ClickEffectPrefab, raycastHit.point, Quaternion.identity);
            }
        }

	}

    public void SetCurseTalk()
    {
        Cursor.SetCursor(NPCTalk, hotSpot, cursorMode);
    }

    public void SetCurseNormal()
    {
        Cursor.SetCursor(Normal, hotSpot, cursorMode);
    }
}
