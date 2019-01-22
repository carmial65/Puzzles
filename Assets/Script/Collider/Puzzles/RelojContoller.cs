using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelojContoller : MonoBehaviour {

	void OnTriggerEnter (){

		Debug.Log ("GUU");

		if (Input.GetKey (KeyCode.Z)) {
			GameManager.gM.RPuzzle ();
		}
	}
}
