using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ParticleSpawner : MonoBehaviour {


	public GUIStyle s;


	public ParticlePreview[] particles;

	public List<GameObject> isntantiaed =  new List<GameObject>();

	private int index = 0;



	void OnGUI() {

		Vector2 pos = new Vector2(PConfig.ButtonWindth * 0.2f, PConfig.ButtinHeight * 0.5f);

		if(GUI.Button(new Rect(pos.x, pos.y, PConfig.ButtonWindth * 0.5f, PConfig.ButtinHeight), "<")) {
			if(index > 0) {
				index--;
			} else {
				index = particles.Length - 1;
			}
		}

		string name = particles[index].particle.name.Replace("_", " ");
		pos.x +=  PConfig.ButtonWindth * 0.6f;
		GUI.Label(new Rect(pos.x, pos.y, PConfig.ButtonWindth * 2.5f, PConfig.ButtinHeight), name, s);

		pos.x +=  PConfig.ButtonWindth * 2.6f;
		if(GUI.Button(new Rect(pos.x, pos.y, PConfig.ButtonWindth * 0.5f, PConfig.ButtinHeight), ">")) {
			if(index +1 < particles.Length) {
				index++;
			} else {
				index = 0;
			}
		}
		
		pos = new Vector2(PConfig.ButtonWindth * 0.2f, PConfig.ButtinHeight * 0.5f);
		pos.y +=PConfig.ButtinHeight * 1.5f;

		if(GUI.Button(new Rect(pos.x, pos.y, PConfig.ButtonWindth , PConfig.ButtinHeight), "Clear")) {
			foreach(GameObject o in isntantiaed) {
				Destroy(o);
			}

			isntantiaed.Clear();
		}

	}

	
	void Update() {

		if(Input.GetMouseButtonDown(0)) {

			Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
			RaycastHit hit;
			
			if( Physics.Raycast( ray, out hit, Mathf.Infinity ) ){
				Vector3 pos = new Vector3(hit.point.x, particles[index].y, hit.point.z);
				GameObject p = Instantiate(particles[index].particle, pos, Quaternion.identity) as GameObject;
			//	p.transform.position = 
				
				isntantiaed.Add(p);
				
				
			}
		}

	}
}
