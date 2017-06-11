using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System.Linq;

public class PlayerAttack : MonoBehaviour {

	[SerializeField]
	private SpeechMessage speechMessage;
	[SerializeField] GameObject worldPanel;
	[SerializeField] GameObject hazeroPrefab;
	[SerializeField] GameObject sunderPrefab;
	[SerializeField] GameObject meteoPrefab;
	[SerializeField] GameObject spherePrefab;
	GameObject ins;

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
			AudioManager.Instance.PlaySE("magic-ice2");
			ins = Instantiate (hazeroPrefab, transform.position, Quaternion.identity);
			ins.GetComponent<EffectSettings> ().Target = this.transform.GetChild(0).gameObject;
			ins = Instantiate (spherePrefab, transform.position, Quaternion.identity);
			ins.GetComponent<MoveSphere> ().targetPosition = this.transform.GetChild (0).gameObject.transform.position;
		}
		if (Words.sunder.Count (message => message == mes) > 0) {
			AudioManager.Instance.PlaySE("magic-electron4");
			ins = Instantiate (sunderPrefab, transform.position, Quaternion.identity);
			ins.GetComponent<EffectSettings> ().Target = this.transform.GetChild(0).gameObject;
			ins = Instantiate (spherePrefab, transform.position, Quaternion.identity);
			ins.GetComponent<MoveSphere> ().targetPosition = this.transform.GetChild (0).gameObject.transform.position;
		}
		if (Words.meteo.Count (message => message == mes) > 0) {
			AudioManager.Instance.PlaySE("magic-flame2");
			ins = Instantiate (meteoPrefab, transform.position, Quaternion.identity);
			ins.GetComponent<EffectSettings> ().Target = this.transform.GetChild(0).gameObject;
			ins = Instantiate (spherePrefab, transform.position, Quaternion.identity);
			ins.GetComponent<MoveSphere> ().targetPosition = this.transform.GetChild (0).gameObject.transform.position;
		}
		if (Words.world.Count (message => message == mes) > 0) {
			AudioManager.Instance.PlaySE("nc150248");
			TimeManager.Instance.SetSlow ();
			worldPanel.SetActive (true);
			Invoke ("worldFunc",5f);
		}
	}

	void worldFunc(){
		worldPanel.SetActive (false);
	}
}
