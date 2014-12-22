using UnityEngine;

public class Runner : MonoBehaviour {

	public static float distanceTraveled;
	private static int boosts;
	
	public float acceleration;
	public Vector3 boostVelocity, jumpVelocity;
	public float gameOverY;
	
	private bool touchingPlatform;
	private Vector3 startPosition;

	void OnGUI(){

		//Move when done
		GUI.Box(new Rect(10,Screen.height - 160,150,150), "Colour Selector");

		if(GUI.Button (new Rect(20,Screen.height - 40,80,20), "Blue"))
		{
			Debug.Log("Colour 1 select");
			gameObject.renderer.material.color = Color.blue;

		}

		if(GUI.Button (new Rect(20,Screen.height -  70,80,20), "Yellow"))
		{
			Debug.Log("Colour 2 select");
			gameObject.renderer.material.color = Color.yellow;
		}
		if(GUI.Button (new Rect(20,Screen.height - 100,80,20), "Green"))
		{
			Debug.Log("Colour 3 select");
			gameObject.renderer.material.color = Color.green;
			//No Pink option in Color. Maybe we can create our own selector if you want pink as an option
		}

	}


	void Start () {
		GameEventManager.GameStart += GameStart;
		GameEventManager.GameOver += GameOver;
		startPosition = transform.localPosition;
		renderer.enabled = false;
		rigidbody.isKinematic = true;
		enabled = false;
	}
	
	void Update () {
		if(Input.GetButtonDown("Jump")){
			if(touchingPlatform){
				rigidbody.AddForce(jumpVelocity, ForceMode.VelocityChange);
				touchingPlatform = false;
			}
			else if(boosts > 0){
				rigidbody.AddForce(boostVelocity, ForceMode.VelocityChange);
				boosts -= 1;
				GUIManager.SetBoosts(boosts);
			}
		}
		distanceTraveled = transform.localPosition.x;
		GUIManager.SetDistance(distanceTraveled);
		
		if(transform.localPosition.y < gameOverY){
			GameEventManager.TriggerGameOver();
		}
	}
	
	void FixedUpdate () {
		if(touchingPlatform){
			rigidbody.AddForce(acceleration, 0f, 0f, ForceMode.Acceleration);
		}
	}

	void OnCollisionEnter () {
		touchingPlatform = true;
	}

	void OnCollisionExit () {
		touchingPlatform = false;
	}

	private void GameStart () {
		boosts = 0;
		GUIManager.SetBoosts(boosts);
		distanceTraveled = 0f;
		GUIManager.SetDistance(distanceTraveled);
		transform.localPosition = startPosition;
		renderer.enabled = true;
		rigidbody.isKinematic = false;
		enabled = true;
	}
	
	private void GameOver () {
		renderer.enabled = false;
		rigidbody.isKinematic = true;
		enabled = false;
	}
	
	public static void AddBoost(){
		boosts += 1;
		GUIManager.SetBoosts(boosts);
	}

}