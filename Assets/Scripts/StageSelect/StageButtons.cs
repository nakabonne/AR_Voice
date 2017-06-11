using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageButtons : MonoBehaviour {
	void Start() {
		AudioManager.Instance.PlayBGM("bgm_maoudamashii_cyber45");
	}

	public void GoMain(int stage){
		MySceneManager.Instance.GoToMain (stage);
	}
}
