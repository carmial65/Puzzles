using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCamara1 : MonoBehaviour {

	void OnTriggerEnter (){


		if (Input.GetKey (KeyCode.Z)) {
			GameManager.gM.ChangeCamera1 ();
		}
	}
}
