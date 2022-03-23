using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour {
	public TextMeshProUGUI Text;
	public Button Button;
	public StringEvent NextStoryEvent;

	private StorySelection _selection;

	public void Init(StorySelection selected) {
		_selection = selected;
		Text.text = selected.Button;

		if (selected.CheckConditions()) {
			Button.onClick.AddListener(OnClick);
		} else {
			Button.interactable = false;
		}
	}

	private void OnClick() {
		_selection.ExecuteActions();
		NextStoryEvent.Raise(_selection.Next.ID);
	}
}
