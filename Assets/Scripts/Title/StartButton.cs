using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {
	void Start() {
		AudioManager.Instance.PlayBGM("bgm_maoudamashii_cyber40");
	}

	public void ButtonStart(){
		MySceneManager.Instance.GoToStageSelect();

	}
}
