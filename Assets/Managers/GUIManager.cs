using UnityEngine;

public class GUIManager : MonoBehaviour {
	
	private static GUIManager instance;
	
	public GUIText boostsText, distanceText, gameOverText, instructionsText, runnerText;
	public GameObject pinkSelector, yellowSelector, blueSelector;
	
	void Start () {
		instance = this;
		GameEventManager.GameStart += GameStart;
		GameEventManager.GameOver += GameOver;
		gameOverText.enabled = false;
		pinkSelector.renderer.enabled = false;
		yellowSelector.renderer.enabled = false;
		blueSelector.renderer.enabled = false;
	}

	void Update () {
		if(Input.GetButtonDown("Jump")){
			GameEventManager.TriggerGameStart();
		}
	}
	
	private void GameStart () {
		gameOverText.enabled = false;
		instructionsText.enabled = false;
		runnerText.enabled = false;
		enabled = false;
		pinkSelector.renderer.enabled = true;
		yellowSelector.renderer.enabled = true;
		blueSelector.renderer.enabled = true;
	}
	
	private void GameOver () {
		gameOverText.enabled = true;
		instructionsText.enabled = true;
		enabled = true;
	}
	
	public static void SetBoosts(int boosts){
		instance.boostsText.text = boosts.ToString();
	}

	public static void SetDistance(float distance){
		instance.distanceText.text = distance.ToString("f0");
	}
}