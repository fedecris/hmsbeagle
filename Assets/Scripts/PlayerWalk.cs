using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour {

	public float playerSpeed; //5

	protected float radius = 0.01f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float cameraFacing = Camera.main.transform.eulerAngles.x;

		//Debug.Log("ANGULO: " + cameraFacing);              

		if ( (cameraFacing > 10) && (cameraFacing < 150) )
		{
			Vector3 validPos = transform.position + Camera.main.transform.forward * playerSpeed / 2f;
			//Debug.Log ("currPos" + transform.position);
			//Debug.Log ("newPos" + newPos);
			if (!Physics.CheckSphere (validPos, radius))
				transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
		}
	}
}
