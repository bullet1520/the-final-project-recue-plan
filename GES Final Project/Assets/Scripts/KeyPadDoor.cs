using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadDoor : MonoBehaviour, IActivatable
{
    [SerializeField]
    string nameText;

    [SerializeField]
    public static string theCode = "GRBY";
    public static string PlayerCode = "";

    public static int digitsEntered = 0;

    private Animator animator;
    private bool isLocked, isOpen;

    [SerializeField]
    GameObject blue;

    [SerializeField]
    GameObject red;

    [SerializeField]
    GameObject green;

    [SerializeField]
    GameObject yellow;

    public string NameText
    {
        get
        {
            string toReturn = nameText;
            //throw new NotImplementedException();

            if (isOpen)
                toReturn = "Unlocked";

            //else if ()
            //    {

            //    }

            return toReturn;
        }
    }


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update ()
    {
        if (digitsEntered == 4)
        {
            Debug.Log(PlayerCode);

            if (PlayerCode == theCode)
            {
                DoActivate();
                Debug.Log("Correct Code Entered!");
                isLocked = false;
                isOpen = true;
            }

            else
            {
                PlayerCode = "";
                digitsEntered = 0;
                Debug.Log ("Try again!");

            }


        }


        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetBool("isDoorOpen", true);
            isOpen = true;
            animator.Play("DoorOpen");
        }

    }

    //void OnMouseClick()
    //{
    //    //PlayerCode += GameObject.Find  GameObject.Name;
    //    digitsEntered += 1;


    //}

    public void DoActivate()
    {
        //throw new NotImplementedException();

        if (!isOpen)
        {
            if (!isLocked && PlayerCode == theCode)
            {
                animator.SetBool("isDoorOpen", true);
                isOpen = true;
            }


        }

    }
}
