using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static bool isStarted;

	// Use this for initialization
	void Start () {
		GameStart();
		AudioManager.Instance.PlayBGM("test");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			AudioManager.Instance.PlaySE("Beam");
		}
		if (Input.GetMouseButtonDown (1)) {
			AudioManager.Instance.PlaySE("Explosion");

		}
	}

	void GameStart(){
		isStarted = true;
	}

	public static void GameEnd(){
		isStarted = false;
	}
}
