/// <summary>
/// 使い方
/// ParticleManager.Instance.Create("パーティクル名");
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : SingletonMonoBehaviour<ParticleManager> {

	public GameObject Create(string name){
		return (GameObject)Resources.Load (name);
	}
}
