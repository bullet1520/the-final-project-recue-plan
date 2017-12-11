using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenericActivatedObject : MonoBehaviour, IActivatable 
{
    [SerializeField]
    private string nameText = "Generic Activated Object";

    private GameObject playeR;

    private string button;

    public string NameText
    {
        get
        {
            return nameText;
        }
    }

    void Start()
    {
       GameObject.Find("Door").GetComponent<KeyPadDoor>();
       button = this.nameText;
       playeR = GameObject.FindWithTag("Player");
    }

    public void DoActivate()
    {
        Debug.Log(this.gameObject.name + " was activated.");

        if (nameText == "B" || nameText == "G" || nameText == "R" || nameText == "Y")
            KeyPadDoor.PlayerCode += button;
            KeyPadDoor.digitsEntered += 1;

        //if (nameText == "Mysyerious Monolith")
        //{
        //    playeR.transform.position = new Vector3(439, 4, 431);

        //}


        if (nameText == "End?")
        {
            SceneManager.LoadScene("Main_Menu");

        }
    }
}