using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door4 : MonoBehaviour {

	void OnTriggerEnter(){
		Debug.Log ("ggg");
		if (Input.GetKey (KeyCode.Z) && GameManager.gM.key  >= 3) {
			transform.Rotate (new Vector3 (0f, 68f, 0f));
		}
	}
}
