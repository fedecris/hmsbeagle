using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayEvents : MonoBehaviour {

	public TextMesh objectText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void showMessage()	{
		// muestro el texto
		objectText.GetComponentInChildren<Renderer>().enabled = true;
		//codigo para mostrar mensaje en pantalla;

		Debug.Log("SHOW <TEXTO>");
	}

	public void unshowMessage()	{
		// muestro el texto
		objectText.GetComponentInChildren<Renderer>().enabled = false;

		Debug.Log("UNSHOW <TEXTO>");
	}

}
