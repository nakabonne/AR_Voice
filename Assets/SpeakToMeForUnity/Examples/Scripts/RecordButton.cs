using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class RecordButton : MonoBehaviour
{
	Button recordButton;
	[SerializeField] Sprite micOn;
	[SerializeField] Sprite micOff;
	Image frame;

	void Start()
	{
		SpeakToMeForUnity.PrepareRecording();

		recordButton = GetComponent<Button>();
		frame = transform.GetChild (0).gameObject.GetComponent<Image>();
		frame.fillAmount = 0;
	}

	public void OnCallback(string message) {
		Debug.Log(message);

		string[] data = message.Split(':');
		if (data.Length != 2)
			return;

		recordButton.interactable = (data[0] == "true");
	}

	public void OnTapped()
	{
		Debug.Log ("push");
		SpeakToMeForUnity.RecordButtonTapped();
		GetComponent<Image> ().sprite = micOn;
		frame.fillAmount = 1;
		frame.DOFillAmount (0, 3f);
		Invoke ("AfterTapp", 3f);
	}

	void AfterTapp(){
		SpeakToMeForUnity.RecordButtonTapped ();
		GetComponent<Image> ().sprite = micOff;
	}
}
