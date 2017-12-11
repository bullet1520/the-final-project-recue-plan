using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    //Collider Teleporter;
    //GameObject Porter;
    [SerializeField]
    GameObject playeR;

    [SerializeField]
    Transform Spawn;



    // Use this for initialization
    void Start ()
    {
        //playeR = GameObject.tag == "Player";
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void OnTriggerEnter(Collider Teleporter)
    {
        TeleportPlayer();

        //if (Teleporter.CompareTag("Player"))
        //{
        //    Teleporter.transform.position = Spawn.transform.position;
        //}


        //if (Teleporter == playeR && Input.GetButtonDown("Fire1"))
        //{
        //    //playeR = Teleporter.transform.parent.gameObject.transform.parent.gameObject;
        //    //playeR.transform.position = Spawn.transform.position;
        //    //playeR.transform.rotation = Spawn.transform.rotation;
            
            
        //}
    }


    void TeleportPlayer()
    {
        playeR.transform.position = Spawn.transform.position; /*new Vector3(439, 4, 431);*/

    }
}
