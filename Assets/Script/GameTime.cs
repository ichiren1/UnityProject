using UnityEngine;
using System.Collections;

public class GameTime : MonoBehaviour {
	public static float timer; 
	public GameObject refObj;
	
	void Start () {
		timer = 0;
	}
	
	void Update () {
		if(!GameScoreTitle.isClear) //not clear
			timer += Time.deltaTime;
		string minute;
		if(timer/60 >= 10)
			minute = (timer/60).ToString("f0") + ":";
		else 
			minute = "0" + (timer/60).ToString("f0") + ":";
		if(timer%60 >= 10)
			this.guiText.text = minute + (timer%60).ToString("f2");
		else
			this.guiText.text = minute + "0"+ (timer%60).ToString("f2");
	}
}
