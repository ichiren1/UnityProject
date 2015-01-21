using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public AudioClip audioClip;
	public int hitCount;

	AudioSource audioSource;

	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
		hitCount = 0;
	}

	void Update () {
		if(this.transform.position.y < 0 && !audioSource.isPlaying ){
			audioSource.Play();
		}
	}
	
	void OnCollisionStay(Collision other){
		Debug.Log ("aa");
		if(other.gameObject.CompareTag("FalseBlock")){
			Debug.Log ("Hello11");
		}
	}
}
