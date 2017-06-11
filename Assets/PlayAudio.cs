using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AudioManager.Instance.PlayBGM("bgm_mainscene");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
