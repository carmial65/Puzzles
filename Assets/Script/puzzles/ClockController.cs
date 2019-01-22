using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockController : MonoBehaviour {

	private const float
	hoursToDegrees = 360f / 12f,
	minutesToDegrees = 360f / 60f;

	public Transform needleHours, needleMinutes;
	public GameObject texto;

	float hours, minutes;

	void Start (){
		hours = 0f;
		minutes = 0f;
		texto.SetActive (false);
	}

	void IncreaseMinutes (){
		minutes = minutes+1;
		if (minutes == 60) {
			minutes = 0;
			hours = hours+1;
		}
		if(hours == 13){
			hours = 0;
		}
	}

	void DecreaseMinutes (){
		minutes = minutes-1;
		if (minutes == -60) {
			minutes = 0;
			hours = hours-1;
		}
		if(hours == -13){
			hours = 0;
		}
	}

	void Update () {
		if (Input.GetMouseButton (0)) {
			//Voy a aumentar en una unidad los minutos
			IncreaseMinutes();
		}

		if (Input.GetMouseButton (1)) {
			//Voy a disminuir en una unidad los minutos
			DecreaseMinutes();
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}

		Debug.Log (""+hours + "  " + minutes);

		//Rotamos el angulo necesario

		needleHours.localRotation =
			Quaternion.Euler(0f,0f,(float)hours * hoursToDegrees);

		needleMinutes.localRotation =
			Quaternion.Euler(0f,0f,(float)minutes * minutesToDegrees);



		//Comprobar
		if ((hours==9 || hours ==-3) && minutes ==0 && (!Input.GetMouseButton (0) && !(Input.GetMouseButton (1)))){
			texto.SetActive (true);
			Debug.Log ("GANASTE");
			GameManager.gM.IncreaseKey ();
			GameManager.gM.Ganaste ();

		}





	}
}

