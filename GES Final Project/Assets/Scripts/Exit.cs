﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{

    // Use this for initialization
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();

    }
}
