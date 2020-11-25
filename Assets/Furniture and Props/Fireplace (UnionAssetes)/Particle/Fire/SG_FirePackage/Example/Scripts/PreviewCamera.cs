using UnityEngine;
using System.Collections;

public class PreviewCamera : MonoBehaviour {


	private int mode = 0;
	private float speed = 20f;



	public void FixedUpdate(){

		float s = 0f;
		switch(mode) {
		case 0:
			s = speed * 0.3f;
			break;
		case 1:
			s = speed;
			break;
		case 2:
			s = 0;
			break;

		}

		transform.Translate(Vector3.forward *  Input.GetAxis("Mouse ScrollWheel"));

		transform.RotateAround (Vector3.zero, Vector3.up, s * Time.deltaTime);
	}



	void OnGUI() {
		Vector2 pos = new Vector2(Screen.width - PConfig.ButtonWindth * 2f, PConfig.ButtinHeight * 2f);

		string text = "";
		switch(mode) {
		case 0:
			text = "Camera Slow";
			break;
		case 1:
			text = "Camera Fast";
			break;
		case 2:
			text = "Camera Satic";
			break;
			
		}
		if(GUI.Button(new Rect(pos.x, pos.y, PConfig.ButtonWindth * 1.8f, PConfig.ButtinHeight), text)) {
			mode++;
			if(mode > 2) {
				mode = 0;
			}
		}

	}
}
