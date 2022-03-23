using System.Linq;
using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;

// public class ChangeStory : ISelectAction {
// 	[OnInspectorInit("Init")]
// 	[HideIf("@true")]
// 	public StringEvent ChangeStoryEvent;
//
// 	[InlineButton("Find")]
// 	public string id;
//
// 	public void Execute() {
// 		ChangeStoryEvent.Raise(id);
// 	}
//
// 	private void Init() {
// #if UNITY_EDITOR
// 		var guid = UnityEditor.AssetDatabase.FindAssets("t:StringEvent ChangeStory").First();
// 		var path = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
// 		ChangeStoryEvent = UnityEditor.AssetDatabase.LoadAssetAtPath<StringEvent>(path);
// #endif
// 	}
//
// 	private void Find() {
// 		foreach (var guid in UnityEditor.AssetDatabase.FindAssets("t:StoryData")) {
// 			var path = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
// 			var obj = UnityEditor.AssetDatabase.LoadAssetAtPath<StoryData>(path);
// 			if (obj.ID == id)
// 				UnityEditor.Selection.activeObject = obj;
// 		}
// 	}
// }
