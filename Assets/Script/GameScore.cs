using UnityEngine;
using System.Collections;

public class GameScore : MonoBehaviour {
	
	
	void Start () {
		this.guiText.enabled = false;
	}
	
	void Update () {
		if(GameScoreTitle.isClear || GameScoreTitle.isFail){
			this.guiText.enabled = true;
			this.guiText.text = "ぶつかった数　" + Player.hitCount +"回\n";
			string minute;
			string outputTime;
			if(GameTime.timer/60 >= 10)
				minute = (GameTime.timer/60).ToString("f0") + ":";
			else 
				minute = "0" + (GameTime.timer/60).ToString("f0") + ":";
			if(GameTime.timer%60 >= 10)
				outputTime = minute + (GameTime.timer%60).ToString("f2");
			else
				outputTime = minute + "0"+ (GameTime.timer%60).ToString("f2");
			this.guiText.text += "経過した時間　" + outputTime +"\n\n";
			this.guiText.text += "スコア " + ((Player.hp/(GameTime.timer/100))*100).ToString("N0");
			
		}
	}
}
