using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Plane {
	public float xMin, xMax, yMin, yMax;
}

public class Camera1 : MonoBehaviour {

	public Plane myPlane;
	private float speed;

	private float movHorizontal, movVertical; //me crea dos o más variables del mismo tipo y mismo nivel de proteccion
	private Vector3 movimiento;




	// Use this for initialization
	void Start () {
		speed = 2;
	}
	
	// Update is called once per frame
	void Update () {

		movHorizontal = Input.GetAxis ("Horizontal");		//TRANSLATE
		movVertical = Input.GetAxis ("Vertical");			
		movimiento = new Vector3 (movHorizontal, movVertical, 0.0f);
		transform.Translate (movimiento * speed * Time.deltaTime);

		transform.position = new Vector3 (
			Mathf.Clamp (transform.position.x, myPlane.xMin, myPlane.xMax),
			Mathf.Clamp (transform.position.y, myPlane.yMin, myPlane.yMax),
			33.01f
		);

	}
}
