﻿using UnityEngine;
using System.Collections;

public class SecondTrueBlock : MonoBehaviour {
	public GameObject gamePointCounter;
	public GameObject player;
	public AudioClip audioClip;
	AudioSource audioSource;

	
	void Start () {
		//renderer.enabled = false;
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
	}
	
	void Update () {
		if (Player.TrueBlockNum == 2) {
			if(!audioSource.isPlaying){
				audioSource.Play ();
			}
		}
	}
	void OnTriggerEnter(Collider other) {

		if(Player.TrueBlockNum == 2){
		if (other.gameObject.CompareTag ("Player")) {
				Player.TrueBlockNum = 3;
				audioSource.Stop();
				gamePointCounter.GetComponent<GamePointConter>().gamePoint++;
				player.GetComponent<Player>().addGamePoint();
				Destroy(this.gameObject);
			}
		}
	}
	
}