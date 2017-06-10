using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class SpeechMessage : MonoBehaviour
{
	[SerializeField]
	Text speech;

	//イベントを発行する核となるインスタンス
	private Subject<string> speechSubject = new Subject<string>();

	//イベントの購読側だけを公開
	public IObservable<string> OnSpeechChanged
	{
		get { return speechSubject; }
	} 

	public void OnCallback(string message)
	{
		Debug.Log(message);
		speech.text = message;
		speechSubject.OnNext(message);
	}
}
