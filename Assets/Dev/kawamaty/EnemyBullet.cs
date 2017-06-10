using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {
	//// bullet prefab
	public GameObject bullet;

	//// 弾丸発射点
	//public Transform muzzle;
	//// 弾丸の速度
	//public float speed ;//= 10000;
	//public Transform target;


	void Start () {
		
	}
	



	void Update () {
		float speed = 100.0f;
		float step = Time.deltaTime * speed;

		// z キーが押された時
		if(Input.GetKeyDown (KeyCode.Z)){

			GameObject player = GameObject.Find ("Camera");
			GameObject bullets = GameObject.Instantiate(bullet)as GameObject;


			bullet.transform.position = Vector3.MoveTowards(transform.position, player.transform.position,step);

			//		Debug.Log ("current ::  "+transform.position);
			//		Debug.Log (player.transform.position);

		}
		
	}
}

/*// 弾丸の複製
			GameObject bullets = GameObject.Instantiate(bullet)as GameObject;

			Vector3 force;
			//force = this.gameObject.transform.forward * speed;
			// Rigidbodyに力を加えて発射
			bullets.GetComponent<Rigidbody>().AddForce (force);
			// 弾丸の位置を調整
			bullets.transform.position = muzzle.position;
			*/
