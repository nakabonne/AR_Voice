using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
	public GameObject enemy;
	public GameObject imageTarget;
	// Use this for initialization
	void Start () {
		Generate ();
	}
	
	void Generate(){
		Instantiate (enemy);
		GameObject child = Instantiate(enemy) as GameObject;
		child.transform.parent = imageTarget.transform;
		child.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);

	}
}
