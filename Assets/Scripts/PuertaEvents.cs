using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaEvents : MonoBehaviour {

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

}
