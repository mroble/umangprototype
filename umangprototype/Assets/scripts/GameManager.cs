using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static GameManager gm;
	public GameObject player;

	public enum gameStates {Playing, Death, GameOver, BeatLevel};
	public gameStates gameState = gameStates.Playing;
	public int score=0;

	public bool canBeatLevel = false;
	public int beatLevelScore=0;

	public GameObject mainCanvas;
	public Text mainScoreDisplay;
	public GameObject gameOverCanvas;
	public Text gameOverScoreDisplay;


	// Use this for initialization
	void Start () {
		if (gm == null) 
			gm = gameObject.GetComponent<GameManager>();

		if (player == null) {
			player = GameObject.FindWithTag("Player");
		}
		Collect (0);
		gameOverCanvas.SetActive (false);
		//if (canBeatLevel)
		//	beatLevelCanvas.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}


	public void Collect(int amount) {
		score += amount;
		if (canBeatLevel) {
			mainScoreDisplay.text = score.ToString () + " of "+beatLevelScore.ToString ();
		} else {
			mainScoreDisplay.text = score.ToString ();
		}

	}
}
