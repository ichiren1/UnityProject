using UnityEngine;
using System.Collections;

public class HpBar : MonoBehaviour {
	
	void Start () {
	}
	
	void Update () {
		this.transform.position = new Vector3(20, 20, 0);
		this.transform.localScale = new Vector3(Player.hp/100f, 1, 1);
	}
}
