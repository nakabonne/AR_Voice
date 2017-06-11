using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageButtons : MonoBehaviour {

	public void GoMain(int stage){
		MySceneManager.Instance.GoToMain (stage);
	}
}
