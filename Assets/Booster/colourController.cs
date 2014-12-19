using UnityEngine;
using System.Collections;

public class colourController : MonoBehaviour {

	public static Color pink;
	public static Color yellow;
	public static Color blue;
	private static Material mat;

	// Use this for initialization
	void Start () {
		mat = renderer.material;
		pink = new Color (0,0,0,0);
		yellow = new Color (255,0,0,0);
		blue = new Color (0,0,255,0);
	}

	public static void changeCubeColour(string cubeColour){
		if (cubeColour == "pink") {
			mat.color = pink;
			Debug.Log("pink Function Entered In changeCubeColour");
		}
		
		if (cubeColour == "yellow") {
			mat.color = yellow;
			Debug.Log("yellow Function Entered In changeCubeColour");
		}
		
		if (cubeColour == "blue") {
			mat.color = blue;
			Debug.Log("blue Function Entered In changeCubeColour");
		}
	}
}
