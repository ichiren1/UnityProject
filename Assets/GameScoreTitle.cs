using UnityEngine;
using System.Collections;

public class GameScoreTitle : MonoBehaviour {
	public bool isClear;
	
	void Start () {
		this.guiText.enabled = false;
	}
	
	void Update () {
		if(isClear){
			this.guiText.enabled = true;
		}
	}
}
