using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[System.Serializable]
public class myPlayer
{
    public string myString;
    public int myInt;
    public float myFloat;
    public GameObject myGo;
    public Transform myTransform;

}
[System.Serializable]
public class myEnemy
{
    public int myInt;
    public float myFloat;
    public GameObject myGo;
    public Transform myTransform;
}

public class MyScript : MonoBehaviour 
{

    public List<myPlayer> myPlayer;
    public myEnemy myEnemy;

    //字典
    private Dictionary<string, myPlayer> items;
	// Use this for initialization
	void Start () {

        for (int i = 0; i < myPlayer.Count;i++)
        {
            items.Add(myPlayer[i].myString, myPlayer[i]);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    [MenuItem("CONTEXT/Rigidbody/Double Mass")]
    static void DoubleMess (MenuCommand command)
    {
        Rigidbody rigidbody = (Rigidbody) command.context;
        rigidbody.mass = rigidbody.mass * 2;
    }
    [MenuItem("Tools/Transform Tools/Align with ground %t")]
    static void AlignWithGround()
    {
        Transform[] transforms = Selection.transforms;
        foreach (Transform myTransform in transforms)
        {
            RaycastHit hit;
            if (Physics.Raycast(myTransform.position, -Vector3.up, out hit))
            {
                Vector3 targetPosition = hit.point;
                if (myTransform.gameObject.GetComponent<MeshFilter>() != null)
                {
                    Bounds bounds = myTransform.gameObject.GetComponent<MeshFilter>().sharedMesh.bounds;
                    targetPosition.y += bounds.extents.y;
                }
                myTransform.position = targetPosition;
                Vector3 targetRotation = new Vector3(hit.normal.x, myTransform.eulerAngles.y, hit.normal.z);
                myTransform.eulerAngles = targetRotation;
            }
        }
    }
    //[MenuItem("Tools/Transform Tools/Align With Ground")]
    //static void SetMess(MenuCommand command)
    //{
    //    Debug.Log("sm ?");
    //    Transform[] transforms = Selection.transforms;
    //    foreach(Transform transform in transforms)
    //    {
    //        RaycastHit hit;

    //        if(Physics.Raycast(transform.position, -Vector3.up, out hit))
    //        {
    //            Vector3 target = hit.point;
    //            if(transform.gameObject.GetComponent<MeshFilter>() != null)
    //            {
                    
    //            }
    //        }
    //    }
    //}
    //[ContextMenu ("Item added to Context menu")]
    //void TestContextMenu ()
    //{
    //    Debug.Log("ssm");
    //}
}
