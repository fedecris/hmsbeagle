using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {

	public GameObject character;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (character.transform.position, transform.position) < 0.4f) {
			string newCurrent = null;
			if (SceneManager.GetActiveScene().name == "Exterior") {
				newCurrent = "Interior";
			} else {
				newCurrent = "Exterior";
			}
			SceneManager.LoadScene (newCurrent);
		}
	}


}
