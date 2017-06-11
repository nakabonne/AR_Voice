using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {
	GameObject camera;
	void Start(){
		camera = GameObject.Find ("Camera");
		transform.LookAt(camera.transform.position);
		Invoke ("Destroy", 10.0f);
	}
	//bulletではなくthisを使って自分インスタンス自身を参照
	void Update () {
		transform.Translate (0, 0, 10);
	}
		
}