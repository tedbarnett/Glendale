using UnityEngine;
using System.Collections;

public class LogosUrls : MonoBehaviour {

	public Texture2D  UnionAssetsLogo;
	public Texture2D  UnionAssetsLogoHover;
	public string  UnionAssetsURL;
	public Vector2 UAOffset;
	private Rect UARect;


	public Texture2D  DeveloperLogo;
	public Texture2D  DeveloperLogoHover;
	public string  DeveloperURL;

	public Vector2 DevOffset;
	private Rect DevRect;


	private bool isDown = false;


	void Awake() {

		UARect =  new Rect();
		UARect.width = UnionAssetsLogo.width;
		UARect.height = UnionAssetsLogo.height;

		UARect.x = Screen.width - UARect.width + UAOffset.x;
		UARect.y = Screen.height - UARect.height + UAOffset.y;


		DevRect =  new Rect();
		DevRect.width = DeveloperLogo.width;
		DevRect.height = DeveloperLogo.height;
		
		DevRect.x =   DevOffset.x;
		DevRect.y = Screen.height - DevRect.height + DevOffset.y;

	}


	void Update() {
		if(Input.GetMouseButtonDown(0)) {
			isDown = true;
		}
		
		if(Input.GetMouseButtonUp(0)) {
			Vector2 mousePosition = Input.mousePosition;
			mousePosition.y = Screen.height - mousePosition.y;
			
			
			if(UARect.Contains(mousePosition)) {
				Application.OpenURL (UnionAssetsURL);
			}

			if(DevRect.Contains(mousePosition)) {
				Application.OpenURL (DeveloperURL);
			}
			
			isDown = false;
			
		}
	}
	


	void OnGUI() {
		Vector2 mousePosition = Input.mousePosition;
		mousePosition.y = Screen.height - mousePosition.y;


		if(UARect.Contains(mousePosition) && !isDown) {
			GUI.DrawTexture(UARect, UnionAssetsLogoHover);
		} else {
			GUI.DrawTexture(UARect, UnionAssetsLogo);
		}


		if(DevRect.Contains(mousePosition) && !isDown) {
			GUI.DrawTexture(DevRect, DeveloperLogoHover);
		} else {
			GUI.DrawTexture(DevRect, DeveloperLogo);
		}


	
	}

}
