using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class StoryData : SerializedScriptableObject {
	public string ID;

	[TextArea(5, 15)]
	public string Description;

	[HideReferenceObjectPicker]
	[ListDrawerSettings(CustomAddFunction = nameof(AddOption))]
	public List<StorySelection> Options = new();

	private StorySelection AddOption() => new();
}
