using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_script : MonoBehaviour {
	public GameObject bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 10.0f;
		float step = Time.deltaTime * speed;

		GameObject player = GameObject.Find ("Player");

		if (Input.GetKeyDown (KeyCode.Z)) {
			/*GameObject bullets = GameObject.Instantiate (bullet)as GameObject;
			bullet.transform.position = Vector3.MoveTowards(bullet.transform.position, player.transform.position,step);*/


			//http://qiita.com/JunShimura/items/268d5a6ccce303999da8 の位置を指定して配置する
			Vector3 placePosition = new Vector3(-15.6f,9.5f,0);
			Quaternion q = new Quaternion();
			q= Quaternion.identity;
			Instantiate (bullet,placePosition,q);
		}

		bullet.transform.position = Vector3.MoveTowards(bullet.transform.position, player.transform.position,step); 
		//この処理でインスタンスしたbulletもplayer方向に移動させたい
		//いまはインスタンスできるけど、bulletがこの処理で動かない


	//bullet.transform.position = Vector3.MoveTowards(bullet.transform.position, player.transform.position,step);
	//		Debug.Log ("current ::  "+transform.position);
	//		Debug.Log (player.transform.position);
	}
	
}
