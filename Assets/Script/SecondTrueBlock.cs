using UnityEngine;
using System.Collections;

public class SecondTrueBlock : MonoBehaviour {
	public GameObject gamePointCounter;
	public GameObject player;
	
	void Start () {
		//renderer.enabled = false;
	}
	
	void Update () {
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			
			if(Player.TrueBlockNum == 2){
				Player.TrueBlockNum = 3;
				gamePointCounter.GetComponent<GamePointConter>().gamePoint++;
				player.GetComponent<Player>().addGamePoint();
				Destroy(this.gameObject);
			}
		}
	}
	
}