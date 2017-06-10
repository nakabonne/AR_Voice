using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System.Linq;

public class PlayerAttack : MonoBehaviour {

	[SerializeField]
	private SpeechMessage speechMessage;
	[SerializeField]
	GameObject prefab;

	// Use this for initialization
	void Start () {
		speechMessage.OnSpeechChanged.Subscribe(message =>
			{
				Attack(message);
			});
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Attack(string mes){
		if (Words.tanaka.Count (message => message == mes) > 0)
			Instantiate (prefab, new Vector3 (0, 0, 0), Quaternion.identity);
		if (Words.sunder.Count (message => message == mes) > 0)
			Instantiate (prefab, new Vector3 (0, 0, 0), Quaternion.identity);
		if (Words.meteo.Count (message => message == mes) > 0)
			Instantiate (prefab, new Vector3 (0, 0, 0), Quaternion.identity);
		if (Words.fire.Count (message => message == mes) > 0)
			Instantiate (prefab, new Vector3 (0, 0, 0), Quaternion.identity);
	}
}
