using UnityEngine;
using System.Collections;

public class SpotLight : MonoBehaviour {
	private GameObject player = null;
	public float spotLightHeight;

	void Start () {
		this.player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	void Update () {
		this.transform.position = new Vector3 (this.player.transform.position.x, spotLightHeight, this.player.transform.position.z);
	}
}
