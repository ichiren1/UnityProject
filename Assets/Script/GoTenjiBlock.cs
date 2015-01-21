using UnityEngine;
using System.Collections;

public class TenjiBlock : MonoBehaviour {
	public AudioClip audioClip;
	AudioSource audioSource;

	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
	}

	void Update () {
	
	}

	void OnTriggerEnter(Collider other){

	}

	void OnTriggerExit(Collider other){
		if(other.gameObject.CompareTag("Player")){
			audioSource.Stop();
		}
	}

	void OnTriggerStay(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			if(Time.frameCount % 30 == 0){
				audioSource.PlayOneShot(audioClip);
			}
		}
	}
}
