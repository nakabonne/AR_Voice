using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager> {

	int score;

	public void Reset(){
		score = 0;
	}

	public void Set(int s){
		score = s;
	}
}
