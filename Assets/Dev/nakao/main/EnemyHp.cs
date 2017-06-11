using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour {
	int hp = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Damage(int damage){
		hp -= damage;
	}


	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "PlayerBullet") {
			Damage (1);
		}
	}
}
