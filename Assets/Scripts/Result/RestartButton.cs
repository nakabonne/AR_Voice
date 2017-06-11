using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour {

	void Start() {
		AudioManager.Instance.PlayBGM("bgm_maoudamashii_cyber33");
	}

	public void Restart(){
		ScoreManager.Instance.Reset ();
		MySceneManager.Instance.GoToStageSelect ();
	}
}
