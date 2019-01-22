using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valvula4 : MonoBehaviour {


	public GameObject cont;


	void OnMouseDown(){

		cont.gameObject.SendMessage ("Valvula4");

	}

}