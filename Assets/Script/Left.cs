using UnityEngine;
using System.Collections;

public class Left : MonoBehaviour {	
	public Vector3 offset;
	public GameObject refObj;
	
	void Start () {
	}
	
	void Update () {
		this.transform.position = new Vector3 (this.offset.x, this.offset.y, this.offset.z);
		this.offset.x = 0.5f + -0.4f * Mathf.Cos(refObj.GetComponent<MainCamera>().cameraRotate);
		this.offset.y = 0.5f + 0.4f * Mathf.Sin(refObj.GetComponent<MainCamera>().cameraRotate);
	}
}