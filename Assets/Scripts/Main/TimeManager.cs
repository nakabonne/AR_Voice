using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : SingletonMonoBehaviour<TimeManager> {

	[SerializeField]
	static float timeLimit = 60;
	float time = timeLimit;
	bool slow = false;
	float slowTime = 5f;

	// Update is called once per frame
	void Update () {
		if (GameManager.isPlaying) {
			if (time > 0) CountDown ();
			if (time < 0) Stop ();
		}
	}

	void Stop(){
		time = 0.0f;
		GameManager.GameEnd (0);
	}
		

	void CountDown(){
		if (slowTime <= 0) {
			slowTime = 5f;
			slow = false;
		}
		if (slow) {
			time -= Time.deltaTime / 2;
			slowTime -= Time.deltaTime;
		}
	    else time -= Time.deltaTime;
	}

	public void SetSlow(){
		slow = true;
	}

	public float GetTime(){
		return time;
	}

}