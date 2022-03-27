using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

public class StorySelection {
	public string Button;

	public bool IsEnding;

	[HideIf("@IsEnding")]
	[InlineButton("CreateNewStoryData", "New", ShowIf = "@Next == null")]
	public StoryData Next;

	[HideReferenceObjectPicker]
	public List<ISelectCondition> Conditions = new();

	[HideReferenceObjectPicker]
	public List<ISelectAction> Actions = new();

	public bool CheckConditions() => Conditions.All(condition => condition.Check());

	[ButtonGroup]
	public void ExecuteActions() => Actions.ForEach(action => action.Execute());

	[ButtonGroup]
	private void PrintConditions() => Debug.Log(CheckConditions());

	private void CreateNewStoryData() {
#if UNITY_EDITOR
		var instance = ScriptableObject.CreateInstance<StoryData>();
		instance.name = "new quest";
		UnityEditor.AssetDatabase.CreateAsset(instance, "Assets/Zomboid1993/Data/Story/new quest.asset");
		Next = instance;
#endif
	}
}
