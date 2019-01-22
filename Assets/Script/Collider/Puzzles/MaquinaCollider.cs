using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaCollider : MonoBehaviour {

	void OnTriggerEnter (){

		Debug.Log ("GUU");

		if (Input.GetKey (KeyCode.Z)) {
			GameManager.gM.MPuzzle ();
		}
	}
}
