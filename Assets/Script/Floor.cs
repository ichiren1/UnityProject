using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {
	public GameObject refObj;
	public Player player;
	public AudioClip audioClip;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		float deadzoneRange = 0.5f;
		bool warningSoundPlaying = false;
		//Debug.Log (player.transform.position.x);
		if (this.transform.localScale.x / 2 < deadzoneRange) {
			Debug.Log ("deadzoneRangeが大きすぎます");
		}

		if (player.transform.position.x > 0) { //Floorの右半分
			if (this.transform.position.x + this.transform.localScale.x / 2 - deadzoneRange < player.transform.position.x) {
				warningSoundPlaying = true;
			}
			if(this.transform.position.z > 0){//前半分
				if (this.transform.position.z + this.transform.localScale.z / 2 - deadzoneRange < player.transform.position.z) {
					warningSoundPlaying = true;
				}
			}else{//後半分
				if (this.transform.position.z - this.transform.localScale.z / 2 + deadzoneRange > player.transform.position.z) {
					warningSoundPlaying = true;
				}
			}
		}else{ //Floorの左半分
			if (this.transform.position.x - this.transform.localScale.x / 2 + deadzoneRange > player.transform.position.x) {
				warningSoundPlaying = true;
			}
			if(this.transform.position.z > 0){//前半分
				if (this.transform.position.z + this.transform.localScale.z / 2 - deadzoneRange < player.transform.position.z) {
					warningSoundPlaying = true;
				}
			}else{//後半分
				if (this.transform.position.z - this.transform.localScale.z / 2 + deadzoneRange > player.transform.position.z) {
					warningSoundPlaying = true;
				}
			}
		}
		if(warningSoundPlaying){
			audioSource.Play();
		}else{
			audioSource.Stop();
		}
	}
}
