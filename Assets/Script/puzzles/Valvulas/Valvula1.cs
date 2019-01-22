using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Valvula1 : MonoBehaviour {


	public GameObject cont;


void OnMouseDown(){

		cont.gameObject.SendMessage ("Valvula1");
	}

}