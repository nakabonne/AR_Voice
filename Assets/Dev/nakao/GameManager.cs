using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static bool isStarted;

	// Use this for initialization
	void Start () {
		GameStart();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GameStart(){
		isStarted = true;
	}

	public static void GameEnd(){
		isStarted = false;
	}
}
