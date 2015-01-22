using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public AudioClip audioClip;
	public static int hitCount;
	public GameObject gameScoreTitle;
	bool isHitCount;
	public static int hp;
	public static int TrueBlockNum;

	AudioSource[] audioSources;

	void Start () {
		audioSources = gameObject.GetComponents<AudioSource>();
		audioSources[0].clip = audioClip;
		isHitCount = false;
		hitCount = 0;
		hp = 100;
		TrueBlockNum = 1;
	}

	void Update () {
		if(this.transform.position.y < 0 && !audioSources[0].isPlaying ){
			if(hp > 0){
				audioSources[0].Play();
			}
		}
		if(hp <= 0){
			GameScoreTitle.isFail = true;
			gameScoreTitle.guiText.text = "Stage Failed...";
		}
	}
	
	void OnControllerColliderHit(ControllerColliderHit hit){
		if(hit.gameObject.tag == "FalseBlock"){
			if(!isHitCount){
				hitCount ++;
				audioSources[1].PlayOneShot(audioSources[1].clip);
				StartCoroutine("waitHitCount");
				if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)){// run
					hp -= 30;
				}else{
					hp -= 10;
				}
				isHitCount = true;
			}
		}
	}
	
	public void addGamePoint(){ // get true block
		audioSources[2].PlayOneShot(audioSources[2].clip);
	}
	
	private IEnumerator waitHitCount(){
		yield return new WaitForSeconds(1.5f);
		isHitCount = false;
	}
}
