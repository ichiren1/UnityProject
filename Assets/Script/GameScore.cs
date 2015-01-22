using UnityEngine;
using System.Collections;

public class GameScore : MonoBehaviour {
	
	
	void Start () {
		this.guiText.enabled = false;
	}
	
	void Update () {
		if(GameScoreTitle.isClear || GameScoreTitle.isFail){
			this.guiText.enabled = true;
			this.guiText.text = "ぶつかった数" + Player.hitCount +"回\n";
			this.guiText.text = "経過した時間" + "秒\n";
		}
	}
}
