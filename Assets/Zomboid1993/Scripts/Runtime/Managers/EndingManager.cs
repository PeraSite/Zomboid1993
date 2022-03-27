using UnityAtoms.BaseAtoms;
using UnityEngine;

public class EndingManager : MonoBehaviour {
	public VoidEvent EndingEvent;
	public GameObject EndingUI;

	private void OnEnable() {
		EndingEvent.Register(OnEnding);
	}

	private void OnDisable() {
		EndingEvent.Unregister(OnEnding);
	}

	private void OnEnding() {
		EndingUI.SetActive(true);
	}
}
