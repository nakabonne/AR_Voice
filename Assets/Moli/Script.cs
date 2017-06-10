using UnityEngine;
using System.Collections;

public class Script : MonoBehaviour 
{
	public Animator targetAnimator;

	string last;
	public void PlayAnim (string animname)
	{
		targetAnimator.StopPlayback();
		if (last == animname)
			targetAnimator.Play (animname);
		else
		targetAnimator.CrossFade (animname, 0.1f);

		last = animname;
	}
}
