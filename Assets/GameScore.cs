using UnityEngine;
using System.Collections;

public class GameScore : MonoBehaviour {
	public GameObject refObj;
	
	
	void Start () {
		this.guiText.enabled = false;
	}
	
	void Update () {
		if(refObj.GetComponent<GameScoreTitle>().isClear){
			this.guiText.enabled = true;
			this.guiText.text = "ぶつかった数" + 1 +"回";
		}
	}
}
