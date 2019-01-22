using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager: MonoBehaviour {

	public  static GameManager gM;
	public int key;

	public float life = 100f;
	public GameObject mainCamara;
	public GameObject camara1;
	public GameObject camara2;



	void Awake (){
		if (gM == null) {
			DontDestroyOnLoad (gameObject);
			gM = this;
		} else if (gM != this) {
			Destroy (gameObject);
		}

	}

	// Use this for initialization
	void Start () {
		
		key = 0;

		mainCamara.SetActive (true);
		camara1.SetActive (false);
		camara2.SetActive (false);


	}

	void Update() {
		
		if (life <=0.0f) {
			Debug.Log("estas muerto");
			SceneManager.LoadScene ("Floor1");
			life = 100f;
			key--;
		}

		if (Input.GetKeyDown (KeyCode.X)) {
			mainCamara.SetActive (true);
			camara1.SetActive (false);
			camara2.SetActive (false);

		}

	}


	public void DecreaseLife (float _life){
		life = life - _life;
	}

	public void VPuzzle (){
		SceneManager.LoadScene ("Pipe");
	}

	public void MPuzzle (){
		SceneManager.LoadScene ("Typewriter");
	}

	public void RPuzzle (){
		SceneManager.LoadScene ("Clock");
	}

	public void IncreaseKey () {
		key++;
	}

	public void Ganaste (){
		SceneManager.LoadScene ("Floor1");
	}

	public void Exit () {
		SceneManager.LoadScene ("Floor1");
	}

	public void ChangeCamera1(){
		mainCamara.SetActive (false);
		camara1.SetActive (true);
		camara2.SetActive (false);

		
	}

	public void ChangeCamera2(){
		mainCamara.SetActive (false);
		camara2.SetActive (true);
		camara1.SetActive (false);


	}

	public void ChangeCamera3(){
		mainCamara.SetActive (false);

		camara2.SetActive (false);
		camara1.SetActive (false);

	}

}

