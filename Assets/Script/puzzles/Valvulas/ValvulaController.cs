using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValvulaController : MonoBehaviour {

	int [] estado = new int[5];

	public GameObject cascada0;
	public GameObject cascada1;
	public GameObject cascada2;
	public GameObject cascada3;
	public GameObject cascada4;
	public GameObject texto;

	void Start () {
		for (int i = 0; i < 5; i++) { 
			estado [i] = 0;
			texto.SetActive (false);
		}
	}
	

	void Update () {

		if (comprobar ()) {
			texto.SetActive (true);
			GameManager.gM.IncreaseKey ();
			GameManager.gM.Ganaste ();
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}

	}

	public void Valvula1 (){

		if (estado [0] == 0) {
			estado [0] = 1;
			cascada0.SetActive (false);
		} else {
			estado [0] = 0;
			cascada0.SetActive (true);
		}

		if (estado [1] == 0) {
			estado [1] = 1;
			cascada1.SetActive (false);
		} else {
			estado [1] = 0;
			cascada1.SetActive (true);
		}

		if (estado [3] == 0) {
			estado [3] = 1;
			cascada3.SetActive (false);
		} else {
			estado [3] = 0;
			cascada3.SetActive (true);
		}

	}

	public void Valvula2 (){

		if (estado [1] == 0) {
			estado [1] = 1;
			cascada1.SetActive (false);
		} else {
			estado [1] = 0;
			cascada1.SetActive (true);
		}

		if (estado [2] == 0) {
			estado [2] = 1;
			cascada2.SetActive (false);
		} else {
			estado [2] = 0;
			cascada2.SetActive (true);
		}

		if (estado [4] == 0) {
			estado [4] = 1;
			cascada4.SetActive (false);
		} else {
			estado [4] = 0;
			cascada4.SetActive (true);
		}

	}

	public void Valvula3 (){

		if (estado [2] == 0) {
			estado [2] = 1;
			cascada2.SetActive (false);
		} else {
			estado [2] = 0;
			cascada2.SetActive (true);
		}

		if (estado [3] == 0) {
			estado [3] = 1;
			cascada3.SetActive (false);
		} else {
			estado [3] = 0;
			cascada3.SetActive (true);
		}

		if (estado [4] == 0) {
			estado [4] = 1;
			cascada4.SetActive (false);
		} else {
			estado [4] = 0;
			cascada4.SetActive (true);
		}

	}

	public void Valvula4 (){

		if (estado [0] == 0) {
			estado [0] = 1;
			cascada0.SetActive (false);
		} else {
			estado [0] = 0;
			cascada0.SetActive (true);
		}

		if (estado [2] == 0) {
			estado [2] = 1;
			cascada2.SetActive (false);
		} else {
			estado [2] = 0;
			cascada2.SetActive (true);
		}

		if (estado [4] == 0) {
			estado [4] = 1;
			cascada4.SetActive (false);
		} else {
			estado [4] = 0;
			cascada4.SetActive (true);
		}

	}


	bool comprobar() {
		int contador = 0;
		for (int i = 0; i < 5; i++) {
			if (estado [i] == 1) {
				contador++;
			}
		}

		if (contador == 5) {
			
			return true;
		} else {
			return false;
		}
	}

}
