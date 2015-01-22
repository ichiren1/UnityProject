using UnityEngine;
using System.Collections;

public class GoToStage01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void GoToStage01Button(){
		Application.LoadLevel("stage01");
	}
}
