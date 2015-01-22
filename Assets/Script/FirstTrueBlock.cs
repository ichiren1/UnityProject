using UnityEngine;
using System.Collections;

public class FirstTrueBlock : MonoBehaviour {
	public GameObject gamePointCounter;
	public GameObject player;

	void Start () {
		//renderer.enabled = false;
	}
	
	void Update () {
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {

			if(Player.TrueBlockNum == 1){
				Player.TrueBlockNum = 2;
				gamePointCounter.GetComponent<GamePointConter>().gamePoint++;
				player.GetComponent<Player>().addGamePoint();
				Destroy(this.gameObject);
			}
		}
	}
	
}