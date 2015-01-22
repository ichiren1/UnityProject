using UnityEngine;
using System.Collections;

public class GamePointConter : MonoBehaviour {
	public int gamePoint;
	public int gameMaxPoint;
	
	// Use this for initialization
	void Start () {
		gamePoint = 0;
		this.guiText.text = "☆";
	}
	
	// Update is called once per frame
	void Update () {
		if(gamePoint > 0){
			for(int i=0; i < gamePoint; i++){
				this.guiText.text = "★";
			}
			if(gamePoint == gameMaxPoint){
				GameScoreTitle.isClear = true; 
				StartCoroutine("GoToGameTitle");
			}
		}
		if(GameScoreTitle.isFail){
			StartCoroutine("GoToGameTitle");
		}
	}
	
	private IEnumerator GoToGameTitle(){
		yield return new WaitForSeconds(3f);
		Application.LoadLevel("title");
	}
}
