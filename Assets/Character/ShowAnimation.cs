using UnityEngine;
using System.Collections;
//using UnityEditor;

public class ShowAnimation : MonoBehaviour {

	public GameObject [] AinObjs;
	private int CurAinObjCount =0;
	//public GameObject AinObj;
	private Animation ain;
	public AnimationClip [] clips;
	public int CurAnimClip =0;
	public string CurAnimName;
	// Use this for initialization
	void Start () {
		//AddAnim ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public GameObject[] Chrs;
	public int i =0;
	private int curi =0;
	void ChooseChar ()
	{
		CurAinObjCount = i;
		AinObjs [CurAinObjCount].SetActive(false);
		i +=1;
		if(i == AinObjs.Length)
		{
			i =0;
		}
		AinObjs [i].SetActive(true);
		//AddAnim ();
	}

	
	//void AddAnim () 
	//{
	//	ain = AinObjs [i].GetComponent<Animation>();
	//	clips = AnimationUtility.GetAnimationClips(ain);
	//}
	void PlayAnim ()
	{
		AinObjs [i].GetComponent<Animation>().Play (clips [CurAnimClip].name);
		CurAnimName = clips [CurAnimClip].name;
	}
}
