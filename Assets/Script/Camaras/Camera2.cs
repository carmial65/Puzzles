using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Plane2 {
	public float zMin, zMax, yMin, yMax;
}

public class Camera2 : MonoBehaviour {

	public Plane2 myPlane;
	private float speed;

	private float movHorizontal, movVertical; //me crea dos o más variables del mismo tipo y mismo nivel de proteccion
	private Vector3 movimiento;




	// Use this for initialization
	void Start () {
		speed=2;
	}
	
	// Update is called once per frame
	void Update () {

		movHorizontal = Input.GetAxis ("Horizontal");		//TRANSLATE
		movVertical = Input.GetAxis ("Vertical");			
		movimiento = new Vector3 (0.0f, movVertical, movHorizontal);
		transform.Translate (movimiento * speed * Time.deltaTime);

		transform.position = new Vector3 (
			8.84f,
			Mathf.Clamp (transform.position.y, myPlane.yMin, myPlane.yMax),
			Mathf.Clamp (transform.position.z, myPlane.zMin, myPlane.zMax)
		);

	}
}
