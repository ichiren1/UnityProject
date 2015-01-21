using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {
	
	private GameObject player = null;
	public Vector3 offset;
	public float cameraRotate;
	public bool isMenu;
	
	// Use this for initialization
	void Start () {
		this.player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (this.player.transform.position.x + this.offset.x, this.offset.y, this.player.transform.position.z + this.offset.z);
		if (Input.GetKey (KeyCode.Q)) {
			this.cameraRotate += 0.05f;
		}
		if (Input.GetKey (KeyCode.E)) {
			this.cameraRotate -= 0.05f;
		}
		if(Input.GetKey(KeyCode.Z)){
			this.cameraRotate = 0;
		}
		
		
		if(Input.GetKey(KeyCode.Escape)){
			if(!isMenu){
				Time.timeScale = 0;
				Application.LoadLevelAdditive("menu");
				isMenu = true;
			}
		}
		this.offset.x = 3*Mathf.Sin(this.cameraRotate);
		this.offset.z = -3*Mathf.Cos(this.cameraRotate);
		
		this.transform.eulerAngles = new Vector3(0, -60*Mathf.Atan2 (this.offset.z,this.offset.x)-90, 0);
		
	}
}