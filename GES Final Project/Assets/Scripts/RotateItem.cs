using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour {

    [SerializeField]
    float RotX;

    [SerializeField]
    float RotY;

    [SerializeField]
    float RotZ;


    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
       transform.Rotate(RotX /** Time.deltaTime*/, RotY /** Time.deltaTime*/, RotZ /** Time.deltaTime*/);

	}
}
