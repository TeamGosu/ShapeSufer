using UnityEngine;
using System.Collections.Generic;

public class colourController : MonoBehaviour {

	private static Material mat;
	public static Material pink;
	public static Material yellow;
	public static Material blue;

	void Start(){
		//mat = renderer.materials;
		pink = PlatformManager.pink;
		yellow = PlatformManager.yellow;
		blue = PlatformManager.blue;
	}

	public static void changeCubeColour(string cubeColour){
		if (cubeColour == "pink") {
			//mat = pink;
			Debug.Log("pink Function Entered In changeCubeColour");
		}
		
		if (cubeColour == "yellow") {
			Debug.Log("yellow Function Entered In changeCubeColour");
		}
		
		if (cubeColour == "blue") {
			Debug.Log("blue Function Entered In changeCubeColour");
		}
	}
}
