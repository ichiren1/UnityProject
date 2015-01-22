using UnityEngine;
using System.Collections;

public class TrueBlock : MonoBehaviour {
	public GameObject gamePointCounter;
	public GameObject player;
	AudioSource audioSource;
	
	void Start () {
		renderer.enabled = false;
		audioSource = GetComponent<AudioSource>();
		audioSource.Play();
	}

	void Update () {
		if(MainCamera.isMenu)
			audioSource.Stop();
		else if(!audioSource.isPlaying){
			audioSource.Play ();
		}
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			gamePointCounter.GetComponent<GamePointConter>().gamePoint++;
			player.GetComponent<Player>().addGamePoint();
			Destroy(this.gameObject);
		}
	}

}
