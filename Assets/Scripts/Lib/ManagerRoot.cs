using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerRoot : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (this.gameObject);
	}
}
