using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour {
	int hp = 3;

	void Damage(int damage){
		hp -= damage;
	}


	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "smallBullet") {
			Damage (1);
		}else if (other.gameObject.tag == "bigBullet"){
			Damage (2);
		}
	}

	public int GetHp(){
		return hp;
	}
}
