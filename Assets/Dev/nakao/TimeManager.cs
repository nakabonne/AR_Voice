using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : SingletonMonoBehaviour<TimeManager> {

	[SerializeField]
	static float timeLimit = 60;
	float time = timeLimit;
	[SerializeField]
	bool isStarted = false;

	// Update is called once per frame
	void Update () {
		if (GameManager.isStarted) {
			CountDown ();
			if (time < 0.0f) {
				time = 0.0f;
				GameManager.GameEnd ();
			}
		}
	}
		

	void CountDown(){
		if (time > 0) {
			time -= Time.deltaTime;
		}
	}

}