using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {


    int m_Num;

    public int Num
    {
        get
        {
            return m_Num;
        }

        set
        {
            m_Num = value;
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.A))
        {
            Num++;

            print(Num * 2);
        }
    }
}
