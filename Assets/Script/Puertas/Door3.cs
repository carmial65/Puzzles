using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3 : MonoBehaviour {

	void OnTriggerEnter(){
		Debug.Log ("ggg");
		if (Input.GetKey (KeyCode.Z) && GameManager.gM.key  >= 2) {
			transform.Rotate (new Vector3 (0f, -100f, 0f));
		}
	}
}
