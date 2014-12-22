using UnityEngine;
using System.Collections;

public class collisionDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision collision) {

		Debug.Log("platform touch cube");

		//Colour of platform
		//Debug.Log(this.renderer.material.color
		//Colour of cube
		//Debug.Log(collision.gameObject.renderer.material.color);



		if (this.renderer.material.color == collision.gameObject.renderer.material.color)
		{
			Debug.Log("MATCHING");
		} else
		{
			Debug.Log("NOT MATCHING");
		}
	}
}
