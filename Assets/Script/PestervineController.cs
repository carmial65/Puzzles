using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PestervineController : MonoBehaviour {

	public Transform point;
	public Animator plantaAnimator;
	RaycastHit info;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Physics.Raycast (point.transform.position, point.transform.forward, out info, 1000f)){
			if (info.collider.tag == "Player") {
				GameManager.gM.DecreaseLife ((100 / 30) * Time.deltaTime);
				Debug.Log (GameManager.gM.life); 
				plantaAnimator.SetBool ("Ataque", true);
			} else {
				plantaAnimator.SetBool ("Ataque", false);
			}
		}

	}
}



