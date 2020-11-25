#pragma strict
var screen : Texture[] = new Texture[2]; // screen textures
var TV_noise_audio : AudioClip; // Audio

function Start () {
	// hide cursor
	//Screen.showCursor = false;
}

function OnTriggerEnter (obj : Collider) {
	//select screen on 1
	GetComponent.<Renderer>().material.mainTexture = screen[1];
	//play audio
	GetComponent.<AudioSource>().Play();
}

function OnTriggerExit (obj : Collider) {
	//select screen off
	GetComponent.<Renderer>().material.mainTexture = screen[0];
	GetComponent.<AudioSource>().Stop();
}


