using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System.Linq;

public class PlayerAttack : MonoBehaviour {

	[SerializeField]
	private SpeechMessage speechMessage;
	[SerializeField] GameObject hazeroPrefab;
	[SerializeField] GameObject sunderPrefab;
	[SerializeField] GameObject meteoPrefab;

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

	public void Attack(string mes){
		if (Words.hazero.Count (message => message == mes) > 0) {
			Instantiate (hazeroPrefab, transform.position, Quaternion.identity);

		}
		if (Words.sunder.Count (message => message == mes) > 0)
			Instantiate (sunderPrefab, transform.position, Quaternion.identity);
		if (Words.meteo.Count (message => message == mes) > 0)
			Instantiate (meteoPrefab, transform.position, Quaternion.identity);
		if (Words.world.Count (message => message == mes) > 0)
			TimeManager.Instance.SetSlow();
	}
}
