using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaEvents : MonoBehaviour {

	public TextMesh mesaText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void showMessage()	{
		// muestro el texto
		mesaText.GetComponentInChildren<Renderer>().enabled = true;
		//codigo para mostrar mensaje en pantalla;

		Debug.Log("SHOW <TEXTO MESA>");
	}

	public void unshowMessage()	{
		// muestro el texto
		mesaText.GetComponentInChildren<Renderer>().enabled = false;

		Debug.Log("UNSHOW <TEXTO MESA>");
	}

}
