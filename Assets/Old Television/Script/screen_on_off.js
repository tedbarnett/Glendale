#pragma strict
var screen : Texture[] = new Texture[4]; // screen textures
var myCursor : Texture2D; // cursor texture
var id_screen : int; // for texture index which will be placed on the screen
var TV_noise_audio : AudioClip; // Audio

var cursorSizeX: int = 48;  // set to width of your cursor texture
var cursorSizeY: int = 48;  // set to height of your cursor texture
var condition = true;

function Start () {
	//started the variable to 0 which shows the screen off
	id_screen = 0;
	// hide cursor
	//Screen.showCursor = false;
}

function OnMouseEnter () {
	condition = false;
	//show the cursor when it is detected
	//Screen.showCursor = true;
}

function OnMouseExit () {
	condition = true;
	//hide cursor
   	//Screen.showCursor = false;
}

function OnGUI(){
    // display custom cursor
	if(!condition){
    GUI.DrawTexture (Rect(Input.mousePosition.x-cursorSizeX/2+ cursorSizeX/2, (Screen.height-Input.mousePosition.y)-cursorSizeY/2+ cursorSizeY/2, cursorSizeX, cursorSizeY),myCursor);
    }
}

function OnMouseDown () {
//increase variable by one to switch the screen
id_screen++;
//play audio
GetComponent.<AudioSource>().Play();

//compare the value of the variable to determine which screen to place
if (id_screen == 1){
		//select screen on 1
		GetComponent.<Renderer>().material.mainTexture = screen[1];
	 }
	 
	 else if (id_screen == 2){
		//select screen on 2
		GetComponent.<Renderer>().material.mainTexture = screen[2];
	 }
   	
   	else if (id_screen == 3){
		//select screen on 3
		GetComponent.<Renderer>().material.mainTexture = screen[3];
	 }
	 
	 else if (id_screen == 4){
		//select screen off
		GetComponent.<Renderer>().material.mainTexture = screen[0];
		
		//when the variable is 4 again assigned a value of 0 to turn off the screen and stop the audio
		id_screen = 0;
		GetComponent.<AudioSource>().Stop();
	 }
}



 