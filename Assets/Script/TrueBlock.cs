using UnityEngine;
using System.Collections;

public class TrueBlock : MonoBehaviour {
	public GameObject gamePointCounter;
	public GameObject player;
	
	void Start () {
		renderer.enabled = false;
	}

	void Update () {
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			gamePointCounter.GetComponent<GamePointConter>().gamePoint++;
			player.GetComponent<Player>().addGamePoint();
			Destroy(this.gameObject);
		}
	}

}
