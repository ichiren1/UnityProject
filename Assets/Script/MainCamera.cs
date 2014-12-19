using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {
	
	private GameObject player = null;
	
	public Vector3 offset;
	
	// Use this for initialization
	void Start () {
		this.player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (this.player.transform.position.x + this.offset.x, this.offset.y, this.player.transform.position.z + this.offset.z);
	}
}