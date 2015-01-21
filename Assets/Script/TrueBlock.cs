using UnityEngine;
using System.Collections;

public class TrueBlock : MonoBehaviour {
	public GameObject refObj;
	
	void Start () {
	}

	void Update () {
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			refObj.GetComponent<GamePointConter>().gamePoint++;
			Destroy(this.gameObject);
		}
	}

}
