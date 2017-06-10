using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageButtons : MonoBehaviour {

	public void Stage1(){
		GoMain (1);
	}
	public void Stage2(){
		GoMain (2);
	}
	public void Stage3(){
		GoMain (3);
	}

	void GoMain(int stage){
		MySceneManager.Instance.GoToMain (stage);
	}
}
