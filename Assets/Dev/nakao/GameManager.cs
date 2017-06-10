using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static bool isStarted;

	// Use this for initialization
	void Start () {
		GameStart();
	}

	void GameStart(){
		isStarted = true;
	}

	public static void GameEnd(int score){
		ScoreManager.Instance.Set (score);
		isStarted = false;
	}
}
