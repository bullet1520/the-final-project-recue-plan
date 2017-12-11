using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

    [SerializeField]
    GameObject toOrbit;

    [SerializeField]
    float speed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //transform.LookAt(toOrbit.transform.position, Vector3.up);
        Revolve();
	}

    void Revolve()
    {
        transform.RotateAround(toOrbit.transform.position, Vector3.down, speed * Time.deltaTime);
        
    }


}
