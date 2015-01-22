using UnityEngine;
using System.Collections;

public class GameScoreTitle : MonoBehaviour {
	public static bool isClear;
	public static bool isFail;
	
	void Start () {
		isClear = false;
		isFail = false;
		this.guiText.enabled = false;
		this.guiText.text = "Stage Clear\nCongratulation!\n";
	}
	
	void Update () {
		if(isClear || isFail){
			this.guiText.enabled = true;
		}
	}
}
