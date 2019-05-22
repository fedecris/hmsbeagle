using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaEvents : MonoBehaviour {

	public TextMesh camaroteText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Entrar al camarote
    public void entrar()
    {
        SceneManager.LoadScene("Interior");
    }
    
    // Salir a la cubierta
    public void salir()
    {
        SceneManager.LoadScene("Exterior");
    }	

	public void showMessage()	{
		// muestro el texto
		camaroteText.GetComponentInChildren<Renderer>().enabled = true;
		//codigo para mostrar mensaje en pantalla;

		Debug.Log("SHOW <TEXTO MESA>");
	}

	public void unshowMessage()	{
		// muestro el texto
		camaroteText.GetComponentInChildren<Renderer>().enabled = false;

		Debug.Log("UNSHOW <TEXTO MESA>");
	}

}
