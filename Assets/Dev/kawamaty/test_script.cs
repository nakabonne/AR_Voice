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
			//GameObject bullets = GameObject.Instantiate (bullet)as GameObject;
			Vector3 placePosition = new Vector3(-15.6f,9.5f,0);
			Quaternion q = new Quaternion();
			q= Quaternion.identity;
			Instantiate (bullet,placePosition,q);
			//bullet.transform.position = Vector3.MoveTowards(bullet.transform.position, player.transform.position,1);
		}
		//bullet.transform.position = Vector3.MoveTowards(bullet.transform.position, player.transform.position,step);
		bullet.transform.position = Vector3.MoveTowards(bullet.transform.position, player.transform.position,1);

	//		Debug.Log ("current ::  "+transform.position);
	//		Debug.Log (player.transform.position);
	}
	
}
