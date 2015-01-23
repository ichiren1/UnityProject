using UnityEngine;
using System.Collections;

public class TenjiBlockWarning : MonoBehaviour {
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
			if(!MainCamera.isMenu){
				if(!audioSource.isPlaying)
					audioSource.Play();
			}
		}
	}
}
