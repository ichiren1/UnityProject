using UnityEngine;
using System.Collections;

public class GamePointConter : MonoBehaviour {
	public int gamePoint;
	public int gameMaxPoint;
	public GameObject refObj;
	
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
				refObj.GetComponent<GameScoreTitle>().isClear = true; 
				StartCoroutine("GameClear");
			}
		}
	}
	
	private IEnumerator GameClear(){
		yield return new WaitForSeconds(2f);
		Application.LoadLevel("title");
	}
}
