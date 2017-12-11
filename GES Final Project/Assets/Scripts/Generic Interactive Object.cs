using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericInteractiveObject : MonoBehaviour, IActivatable
{
    public string NameText
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public void DoActivate()
    {
        throw new System.NotImplementedException();
        Debug.Log(transform.name + " was activated");
    }

    //private void Start()
    //{
    //    DoActivate();

    //}







}
