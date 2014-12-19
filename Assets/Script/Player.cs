using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public int getObjectNum;

	public void addObjectNum(){
		getObjectNum ++;
		Debug.Log ("Hello");
	}

	void Start () {
		getObjectNum = 0;
	}

	void Update () {
	
	}
	
}
