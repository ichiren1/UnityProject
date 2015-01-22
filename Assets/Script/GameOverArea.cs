using UnityEngine;
using System.Collections;

public class GameOverArea : MonoBehaviour {

	void Start () {
		renderer.enabled = false;
	}

	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		Application.LoadLevel (Application.loadedLevel); //
	}

}
