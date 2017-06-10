using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLabel : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		this.GetComponent<Text> ().text = ScoreManager.Instance.score.ToString();
	}
}
