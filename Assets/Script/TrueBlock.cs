using UnityEngine;
using System.Collections;

public class TrueBlock : MonoBehaviour {
	public GameObject refObj;
	void Start () {
	
	}

	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			refObj.GetComponent<Player>().getObjectNum++;
			Destroy(this.gameObject);
			Debug.Log (refObj.GetComponent<Player>().getObjectNum);
		}
	}

}
