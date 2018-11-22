using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerSpawn : MonoBehaviour {

    public AudioClip AudioClip;
    public GameObject[] Prefabs;
    private GameObject[] Charactors;
    private GameObject InputField;
    private InputField inputField;
    private int SelectedIndex = 0;

    private string PlayerName;
	// Use this for initialization
	void Start ()
    {
        Charactors = new GameObject[Prefabs.Length];


        for (int i = 0; i < Prefabs.Length;++i)
        {
            Charactors[i] = Instantiate(Prefabs[i], transform.position, transform.rotation);
        }

        ShowSelectedRole();

        InputField = GameObject.Find("Canvas/InputBackground");
        inputField = InputField.GetComponentInChildren<InputField>();

	}
	


    void ShowSelectedRole()
    {
        //显示一个角色
        Charactors[SelectedIndex].SetActive(true);

        for (int i = 0; i < Charactors.Length; i++)
        {
            if(i != SelectedIndex)
            {
                Charactors[i].SetActive(false);
            }
        }
    }

    public void OnPreviousClick()
    {
        SelectedIndex--;
        if(SelectedIndex < 0)
        {
            SelectedIndex = Charactors.Length - 1;
        }
        ShowSelectedRole();
        AudioSource.PlayClipAtPoint(AudioClip, transform.position);
    }

    public void OnNextClick()
    {
        SelectedIndex++;
        SelectedIndex %= (Charactors.Length - 1);
        ShowSelectedRole();
        AudioSource.PlayClipAtPoint(AudioClip, transform.position);
    }

    public void OnOKButtonClick()
    {

        AudioSource.PlayClipAtPoint(AudioClip, transform.position);
        //跳转到下一个场景, 保存玩家所选的角色以及名称
        PlayerName = inputField.text;

        SceneManager.LoadScene(2);

        PlayerPrefs.SetString("SelectedIndex", PlayerName);
        PlayerPrefs.SetInt("SelectedIndex", SelectedIndex);

    }



}
