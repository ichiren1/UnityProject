using UnityEngine;
using System.Collections;

public class FifthTrueBlock : MonoBehaviour {
	public GameObject gamePointCounter;
	public GameObject player;
	public AudioClip audioClip;
	AudioSource audioSource;
	
	
	void Start () {
		renderer.enabled = false;
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
	}
	
	void Update () {
		if (Player.TrueBlockNum == 5) {
			if(!audioSource.isPlaying){
				audioSource.Play ();
			}
		}
	}
	void OnTriggerEnter(Collider other) {
		
		if(Player.TrueBlockNum == 5){
			if (other.gameObject.CompareTag ("Player")) {
				Player.TrueBlockNum = 0;
				audioSource.Stop();
				gamePointCounter.GetComponent<GamePointConter>().gamePoint++;
				player.GetComponent<Player>().addGamePoint();
				Destroy(this.gameObject);
			}
		}
	}
	
}