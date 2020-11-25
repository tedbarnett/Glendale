	var myClip: AudioClip;
	var playClipInterval = 12; // Play sound after this many seconds
	var clipNotPlayed : boolean = true; // Clip not played yet?

function Update() {
	var timeNow = Time.realtimeSinceStartup;
//	Debug.Log (timeNow); // display current time
		if( (timeNow > playClipInterval) && clipNotPlayed )
		{
			GetComponent.<AudioSource>().PlayOneShot(myClip);
			clipNotPlayed = false;
		}
		
}