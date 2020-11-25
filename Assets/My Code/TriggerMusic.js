var myClip: AudioClip;
var clipNotPlayed : boolean = true; // Clip not played yet?

function OnTriggerEnter (myTrigger : Collider) {
	if(myTrigger.gameObject.name == "First Person Controller" && clipNotPlayed){
		GetComponent.<AudioSource>().PlayOneShot(myClip);
		clipNotPlayed = false;
 	}
	if(myTrigger.gameObject.name == "Oculus" && clipNotPlayed){
		GetComponent.<AudioSource>().PlayOneShot(myClip);
		clipNotPlayed = false;
 	}
}