using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	//オブジェクトにマウスカーソルが重なっている際実行
	void OnMouseOver(){
		this.guiText.fontStyle = FontStyle.Bold;
	}
	
	//オブジェクトからマウスカーソルが離れた際実行
	void OnMouseExit(){
		this.guiText.fontStyle = FontStyle.Normal;
	}
}

