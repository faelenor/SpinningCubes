using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkedRotation : NetworkBehaviour
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(isLocalPlayer)
            gameObject.transform.RotateAround(gameObject.transform.position, Vector3.up, 50 * Time.deltaTime);
    }
}
