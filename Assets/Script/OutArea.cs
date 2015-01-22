using UnityEngine;
using System.Collections;

public class OutArea : MonoBehaviour {
	public AudioClip audioClip;
	AudioSource audioSource;

	void Start () {
		renderer.enabled = false;
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
	}
	
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		if(!GameScoreTitle.isClear){
			audioSource.Play();
			if(other.CompareTag("Player")){
				Application.LoadLevel (Application.loadedLevel); //
			}
		}
	}
	
}