using UnityEngine;
using System.Collections;

public class CharaVectorMap : MonoBehaviour {
	public GameObject player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.rotation = Quaternion.Euler(0, 0, -1*player.transform.eulerAngles.y+180);
	}
}
