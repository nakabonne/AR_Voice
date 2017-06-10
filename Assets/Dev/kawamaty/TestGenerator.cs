using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGenerator : MonoBehaviour {

	public GameObject bullet;
	float count = 0;
	// Update is called once per frame
	void Update () {
		count += Time.deltaTime*1;
		if (count >= 2) {
			Instantiate (bullet);
			count = 0;
		}
	}
}
