using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControler : MonoBehaviour {

	float walkSpeed; //Velocidad normal
	float runSpeed; //velocidad al correr
	float hangSpeed; //agachado
	float rotacion;
	float speed;


	bool hang; //comprobar

	// Use this for initialization
	void Start () {
		walkSpeed =10f; 
		runSpeed=20f; 
		hangSpeed=5f; 
		rotacion = 100.00f;
		speed = walkSpeed;
		hang = false;

	}
	
	void Update(){
 		

		//correr
		if (Input.GetKey (KeyCode.LeftShift) && hang == false) {
			speed = runSpeed;

	
		} else {
			speed = walkSpeed;
		}


		//agacharse

		if (/*animator.SetBool ("isAbajo", false) && */  hang == false && Input.GetKeyDown (KeyCode.LeftControl)) {
			hang = true;

			/*animator.SetBool ("isAbajo", true)*/
		}

		else if (/*animator.SetBool ("isAbajo", true) && */ hang == true && Input.GetKeyDown (KeyCode.LeftControl)) {
			speed = walkSpeed;
			hang = false;

			/*animator.SetBool ("isAbajo", false)*/
		}


		//andar

		if (Input.GetKey (KeyCode.UpArrow)) {

			if (hang == true) {
				speed = hangSpeed;
			}

			transform.Translate (0, 0, speed*Time.deltaTime );

		}

		if (Input.GetKey (KeyCode.DownArrow)) {

			if (hang == true) {
				speed = hangSpeed;
			}
			transform.Translate (0, 0, -speed*Time.deltaTime);
		}


		//girarse
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (0, rotacion*Time.deltaTime, 0 );
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (0, -rotacion*Time.deltaTime, 0 );
		}   
	}

}
