using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour {

	public void Restart(){
		ScoreManager.Instance.Reset ();
		MySceneManager.Instance.GoToStageSelect ();
	}
}
