using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : SingletonMonoBehaviour<MySceneManager> {

	public void GoToTitle(){
		SceneManager.LoadScene ("Title");
	}

	public void GoToStageSelect(){
		SceneManager.LoadScene ("StageSelect");
	}

	public void GoToMain(int stage){
		StageManager.Instance.stage = stage;
		SceneManager.LoadScene ("Main");
	}

	public void GoToResult(){
		SceneManager.LoadScene ("Result");
	}
}
