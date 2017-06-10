using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class RotateButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public Transform t;
	public int val;
	bool on = false;

	public void OnPointerDown(UnityEngine.EventSystems.PointerEventData data)
	{
		on = true;
	}

	public void OnPointerUp(UnityEngine.EventSystems.PointerEventData data)
	{
		on = false;
	}

	void Update ()
	{
		if (on)
			t.Rotate (Vector3.up * val * 5);
	}
}
