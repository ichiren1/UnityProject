using UnityEngine;
using System.Collections;

public class OjamaBall : MonoBehaviour {
	public Vector3 offset;
	public int pingpongMax;
	public GameObject player;
	public GameObject ojamaeffect;
	
	private AudioSource bomb;
	
	AudioSource[] audioSources;
	// Use this for initialization
	void Start () {
		audioSources = GetComponents<AudioSource>();
		bomb = audioSources[1];
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(!MainCamera.isMenu){
			float frames = Time.frameCount/5;
			float ballx = Mathf.PingPong(frames, pingpongMax) + offset.x - pingpongMax/2;
			float bally = offset.y;
			float ballz = offset.z;
		

			this.transform.position = new Vector3(ballx, bally, ballz);
			if(!audioSources[0].isPlaying){
				audioSources[0].Play();
			}
		}else{
			audioSources[0].Stop();
		}
	}
	
	void OnTriggerEnter(Collider other){
		if(!GameScoreTitle.isClear){
			if(other.gameObject.CompareTag("Player")){
				bomb.PlayOneShot(bomb.clip);
				ojamaeffect.transform.localScale = new Vector3(2000, 2000, 0);
				StartCoroutine("playBombSound");
			}
		}
	}
	
	private IEnumerator playBombSound(){
		yield return new WaitForSeconds(1.0f);
		Application.LoadLevel("stage02");
	}
}
