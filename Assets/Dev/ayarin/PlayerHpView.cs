using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpView : MonoBehaviour {

	public Image hpBar;
	public PlayerHp playerhp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		hpBar.fillAmount = playerhp.GetHp() / 3;
	}
}
