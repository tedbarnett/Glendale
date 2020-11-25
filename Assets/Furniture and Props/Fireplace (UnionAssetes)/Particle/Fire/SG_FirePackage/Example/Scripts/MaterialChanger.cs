using UnityEngine;
using System.Collections;

public class MaterialChanger : MonoBehaviour {

	public GUIStyle s;
	
	
	public Material[] materials;
	public GameObject[] objects;
	private int index = 0;

	
	void OnGUI() {
		
		Vector2 pos = new Vector2(Screen.width - PConfig.ButtonWindth * 4f, PConfig.ButtinHeight * 0.5f);
		
		if(GUI.Button(new Rect(pos.x, pos.y, PConfig.ButtonWindth * 0.5f, PConfig.ButtinHeight), "<")) {
			if(index > 0) {
				index--;
			} else {
				index = materials.Length - 1;
			}

			SwitchMaterial();
		}
		
		pos.x +=  PConfig.ButtonWindth * 0.6f;
		string name = materials[index].name.Replace("_", " ");
		GUI.Label(new Rect(pos.x, pos.y, PConfig.ButtonWindth * 2.5f, PConfig.ButtinHeight), name, s);
		
		pos.x +=  PConfig.ButtonWindth * 2.6f;
		if(GUI.Button(new Rect(pos.x, pos.y, PConfig.ButtonWindth * 0.5f, PConfig.ButtinHeight), ">")) {
			if(index +1 < materials.Length) {
				index++;
			} else {
				index = 0;
			}

			SwitchMaterial();
		}

	}


	private void SwitchMaterial() {
		foreach(GameObject o in objects) {
			o.GetComponent<Renderer>().material = materials[index];
		}
	}
	

}
