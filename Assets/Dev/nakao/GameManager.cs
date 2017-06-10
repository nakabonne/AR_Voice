using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static bool isStarted;

	// Use this for initialization
	void Start () {
		GameStart();
		Instantiate(ParticleManager.Instance.Create ("Part"));
	}

	void GameStart(){
		isStarted = true;
	}

	public static void GameEnd(){
		isStarted = false;
	}
}
