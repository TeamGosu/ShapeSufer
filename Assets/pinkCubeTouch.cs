using UnityEngine;
using System.Collections;

public class pinkCubeTouch : MonoBehaviour {
	
	public Color defaultColour;
	public Color selectedColour;
	private Material mat;

	void Start(){
		mat = renderer.material;
	}
	
	void OnTouchDown(){
		mat.color = selectedColour;
		colourController.changeCubeColour("pink");
	}
	
	void OnTouchUp(){
		mat.color = defaultColour;
	}
	
	void OnTouchStay(){
		mat.color = selectedColour;
	}
	
	void OnTouchExit(){
		mat.color = defaultColour;
	}
}
