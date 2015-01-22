using UnityEngine;
using System.Collections;

public class OjamaBall : MonoBehaviour {
	public Vector3 offset;
	public int pingpongMax;
	public GameObject player;
	
	private AudioSource bomb;
	// Use this for initialization
	void Start () {
		AudioSource[] audioSources = GetComponents<AudioSource>();
		bomb = audioSources[1];
		//renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(!MainCamera.isMenu){
			float frames = Time.frameCount/5;
			float ballx = Mathf.PingPong(frames, pingpongMax) + offset.x - pingpongMax/2;
			float bally = offset.y;
			float ballz = offset.z;
		

			this.transform.position = new Vector3(ballx, bally, ballz);
		}
	}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
			bomb.PlayOneShot(bomb.clip);
			Application.LoadLevel("stage02");
		}
	}
}
