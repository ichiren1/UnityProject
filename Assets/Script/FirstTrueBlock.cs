using UnityEngine;
using System.Collections;

public class FirstTrueBlock : MonoBehaviour {
	public GameObject gamePointCounter;
	public GameObject player;
	public AudioClip audioClip;
	AudioSource audioSource;

	void Start () {
		renderer.enabled = false;
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
		audioSource.Play();
	}
	
	void Update () {
	}
	void OnTriggerEnter(Collider other) {

		if(Player.TrueBlockNum == 1){
		if (other.gameObject.CompareTag ("Player")) {
				Player.TrueBlockNum = 2;
				audioSource.Stop();
				gamePointCounter.GetComponent<GamePointConter>().gamePoint++;
				player.GetComponent<Player>().addGamePoint();
				Destroy(this.gameObject);
			}
		}
	}
	
}