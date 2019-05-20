using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour {

    public int playerSpeed; //5

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float cameraFacing = Camera.main.transform.eulerAngles.x;

		Debug.Log("ANGULO: " + cameraFacing);              

		if ( (cameraFacing > 10) && (cameraFacing < 150) )
		{
			transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
		}
	}
}
