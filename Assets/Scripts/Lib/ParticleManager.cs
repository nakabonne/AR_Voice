/// <summary>
/// 使い方
/// ①Resourcesディレクトリ配下に生成したいパーティクルを配置
/// ②Instantiate(ParticleManager.Instance.Create("パーティクル名"));
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : SingletonMonoBehaviour<ParticleManager> {

	public GameObject Create(string name){
		return (GameObject)Resources.Load (string.Format("Particles/{0}", name));
	}
}
