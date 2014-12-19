#pragma strict

function Start () {
	renderer.enabled = false; //描写しない
}

function Update () {

}

function OnTriggerEnter(myCollider:Collider)
{
  if(myCollider.tag=="Player"){
    Application.LoadLevel(Application.loadedLevel);
  }
}