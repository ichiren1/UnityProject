using UnityEngine;
using System.Collections;

public class TenjiBlockSafe : MonoBehaviour {
	public AudioClip audioClip;
	AudioSource audioSource;

	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
		renderer.enabled = false;
	}

	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		audioSource.Play();
	}
	
	void OnTriggerExit(Collider other){
		if(other.gameObject.CompareTag("Player")){
			audioSource.Stop();
		}
	}
	
	void OnTriggerStay(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			if(Time.frameCount % 30 == 0){
				if(!audioSource.isPlaying)
					audioSource.Play();
			}
		}
	}
}
