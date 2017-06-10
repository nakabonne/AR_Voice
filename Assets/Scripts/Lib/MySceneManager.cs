using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : SingletonMonoBehaviour<MySceneManager> {

	public static void GoToTitle(){
		SceneManager.LoadScene ("Title");
	}

	public static void GoToStageSelect(){
		SceneManager.LoadScene ("StageSelect");
	}

	public static void GoToMain(){
		SceneManager.LoadScene ("Main");
	}

	public static void GoToResult(){
		SceneManager.LoadScene ("Result");
	}
}
