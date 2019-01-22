using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MaquinaControler : MonoBehaviour {

	//string [] palabraCorrecta = new string[3] {"S","I","X"};
	string [] posiciónPalabraMostrada = new string[3] {" "," "," "};
	public TextMesh palabraMostrada;
	public GameObject texto;
	int cont;

	// Use this for initialization
	void Start () {
		cont = 0;
		palabraMostrada.text = " ";
		texto.SetActive (false);
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	//Botones
	public void ButtonA (){
		ComprobarLetra ("A");
		ColocarLetra ("A");
	}

	public void ButtonB (){
		ComprobarLetra ("B");
		ColocarLetra ("B");
	}

	public void ButtonC (){
		ComprobarLetra ("C");
		ColocarLetra ("C");
	}

	public void ButtonD (){
		ComprobarLetra ("D");
		ColocarLetra ("D");
	}

	public void ButtonE (){
		ComprobarLetra ("E");
		ColocarLetra ("E");
	}

	public void ButtonF (){
		ComprobarLetra ("F");
		ColocarLetra ("F");
	}

	public void ButtonG (){
		ComprobarLetra ("G");
		ColocarLetra ("G");
	}

	public void ButtonH (){
		ComprobarLetra ("H");
		ColocarLetra ("H");
	}

	public void ButtonI (){
		ComprobarLetra ("I");
		ColocarLetra ("I");
	}

	public void ButtonJ (){
		ComprobarLetra ("J");
		ColocarLetra ("J");
	}

	public void ButtonK (){
		ComprobarLetra ("K");
		ColocarLetra ("K");
	}

	public void ButtonL (){
		ComprobarLetra ("L");
		ColocarLetra ("L");
	}

	public void ButtonM (){
		ComprobarLetra ("M");
		ColocarLetra ("M");
	}

	public void ButtonN (){
		ComprobarLetra ("N");
		ColocarLetra ("N");
	}

	public void ButtonO (){
		ComprobarLetra ("O");
		ColocarLetra ("O");
	}

	public void ButtonP (){
		ComprobarLetra ("P");
		ColocarLetra ("P");
	}

	public void ButtonQ (){
		ComprobarLetra ("Q");
		ColocarLetra ("Q");
	}

	public void ButtonR (){
		ComprobarLetra ("R");
		ColocarLetra ("R");
	}

	public void ButtonS (){
		ComprobarLetra ("S");
		ColocarLetra ("S");
	}

	public void ButtonT (){
		ComprobarLetra ("T");
		ColocarLetra ("T");
	}

	public void ButtonU (){
		ComprobarLetra ("U");
		ColocarLetra ("U");
	}

	public void ButtonV (){
		ComprobarLetra ("V");
		ColocarLetra ("V");
	}

	public void ButtonW (){
		ComprobarLetra ("W");
		ColocarLetra ("W");
	}

	public void ButtonX (){
		ComprobarLetra ("X");
		ColocarLetra ("X");
	}

	public void ButtonY (){
		ComprobarLetra ("Y");
		ColocarLetra ("Y");
	}

	public void ButtonZ (){
		ComprobarLetra ("Z");
		ColocarLetra ("Z");
	}

	public void ButtonComprobarPalabra() {

		//ganas
		if (cont == 3) {
			texto.SetActive (true);
			GameManager.gM.IncreaseKey ();
			GameManager.gM.Ganaste ();


		} 
		//pierdes/reinicia
		if (palabraMostrada.text == posiciónPalabraMostrada [0] + posiciónPalabraMostrada [1] + posiciónPalabraMostrada [2] && cont != 3) {
			palabraMostrada.text = " ";
		}
	}
		

	void ComprobarLetra (string letraGanadora) {
		
		if (cont == 0 && letraGanadora == "S") {
			cont++;
		} else if (cont == 1 && letraGanadora == "I") {
			cont++;
		} else if (cont == 2 && letraGanadora == "X") {
			cont++;		
		} else {
			cont = 0;
		}
	}
		

	void ColocarLetra (string letra) {

		if (palabraMostrada.text == " ") {
			posiciónPalabraMostrada [0] = letra;
			palabraMostrada.text = posiciónPalabraMostrada [0];
		} else if (palabraMostrada.text == posiciónPalabraMostrada [0]) {
			posiciónPalabraMostrada [1] = letra;
			palabraMostrada.text = posiciónPalabraMostrada [0] + posiciónPalabraMostrada [1];
		} else if (palabraMostrada.text == posiciónPalabraMostrada [0] + posiciónPalabraMostrada [1]) {
				posiciónPalabraMostrada [2] = letra;
				palabraMostrada.text = posiciónPalabraMostrada [0] + posiciónPalabraMostrada [1] + posiciónPalabraMostrada [2];
				Debug.Log (posiciónPalabraMostrada [0] + posiciónPalabraMostrada [1] + posiciónPalabraMostrada [2] + "hola");
		}
	}
}
