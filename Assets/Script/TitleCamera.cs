using UnityEngine;
using System.Collections;

public class TitleCamera : MonoBehaviour {
	public GameObject title;
	public GameObject startbutton;
	public GameObject exitbutton;

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
				title.guiText.enabled= false;
				startbutton.guiText.enabled = false;
				exitbutton.guiText.enabled = false;
				Application.LoadLevelAdditive("stages");

			}
			if(hit.name == "ExitButton"){
				Application.Quit();
			}
		}
	}
}
