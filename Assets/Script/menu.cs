using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {
	public Texture backgroundImage;
	string[] soundEffectNames = {"ゴール", "振り子", "振り子にぶつかる","壁にぶつかる", "安全地帯", "危険地帯", "落下"};
	AudioSource[] audioSources;

	void Start () {
		Time.timeScale = 0;
		audioSources = GetComponents<AudioSource>();
	}
	
	void Update () {
	}
	
	void Awake(){
		Time.timeScale = 0;
	}
	
	void OnDestroy(){
		Time.timeScale = 1;
	}
	
	void OnGUI(){
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundImage);
		
		GUI.Label(new Rect(20, 10, 100, 20), "音一覧");
		for(int i=0; i<soundEffectNames.Length; i++){
			if(GUI.Button(new Rect(20+(Screen.width-40)/3*(i%3), 40+(i/3)*50, (Screen.width-40)/3, 50), soundEffectNames[i]))
				audioSources[i].PlayOneShot(audioSources[i].clip);
		}
		if(GUI.Button (new Rect(Screen.width-120, Screen.height-50, 100, 30), "ゲームに戻る")){
			MainCamera.isMenu = false;
			DestroyObject(this.gameObject);
		}
	}
}

