var clipNotPlayed : boolean = true; // Clip not played yet?
var MovTex:MovieTexture;
var myClip: AudioClip;

function OnTriggerEnter (myTrigger : Collider) {
	if(myTrigger.gameObject.name == "First Person Controller" && clipNotPlayed){
		GetComponent.<Renderer>().material.mainTexture = MovTex;
		MovTex.Play(); 
		GetComponent.<AudioSource>().PlayOneShot(myClip);
		clipNotPlayed = false;
	}
	if(myTrigger.gameObject.name == "Oculus" && clipNotPlayed){
		GetComponent.<Renderer>().material.mainTexture = MovTex;
		MovTex.Play(); 
		GetComponent.<AudioSource>().PlayOneShot(myClip);
		clipNotPlayed = false;
 	}
}