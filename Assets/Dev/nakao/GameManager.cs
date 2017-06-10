using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static bool isPlaying;

	// Use this for initialization
	void Start () {
		GameStart();
	}

	void GameStart(){
		isPlaying = true;
	}

	public static void GameEnd(int score){
		isPlaying = false;
		ScoreManager.Instance.Set (score);
		MySceneManager.Instance.GoToResult ();
	}
}
