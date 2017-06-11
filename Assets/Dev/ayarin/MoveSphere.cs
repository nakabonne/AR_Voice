using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour {

	public Vector3 targetPosition;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 10f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition += Vector3.forward;
	}
}
