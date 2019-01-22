using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public GameObject ButtonNP;
	public GameObject ButtonCP;
	public GameObject ButtonC;
	// Use this for initialization
	void Start () {



		ButtonNP.SetActive (false);
		ButtonCP.SetActive (false);
		ButtonC.SetActive (false);
			
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y == 1.597f){
			Debug.Log ("2");
			ButtonNP.SetActive (true);
			ButtonCP.SetActive (true);
			ButtonC.SetActive (true);
		}
	}

	public void NuevaPartida () {
		SceneManager.LoadScene ("Floor1");

		Debug.Log("NP");
	}

	public void CargarPartida () {
		
		Debug.Log("CP");
	}

	public void Controles() {
		
		SceneManager.LoadScene ("Controls");

	}




		

}
