using UnityEngine;
using System.Collections;

public class TitleCamera : MonoBehaviour {
	GUILayer guiLayer;
	void Start()
	{
		guiLayer = Camera.main.GetComponent<GUILayer>();
	}
	void Update ()
	{
		//シーン上の全GUIElementに対して当たり判定
		GUIElement hit = guiLayer.HitTest (Input.mousePosition);
		if (Input.GetMouseButtonDown (0) && hit != null) {
			//イベント処理
			Debug.Log (hit.name);
			if(hit.name == "StartButton"){
				Application.LoadLevel(1);
				Debug.Log("Hello");
			}
			if(hit.name == "ExitButton"){
				Application.Quit();
			}
		}
	}
}
