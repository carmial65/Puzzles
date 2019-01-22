using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour {

	void OnTriggerEnter(){
		Debug.Log ("ggg");
		if (Input.GetKey (KeyCode.Z) && GameManager.gM.key >= 1) {
			transform.Rotate (new Vector3 (0f, 80f, 0f));
		}
	}
}
