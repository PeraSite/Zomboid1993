using System.Linq;
using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;

public class GameOver : ISelectAction {
	[OnInspectorInit("Init")]
	[HideIf("@true")]
	public StringEvent GameOverEvent;

	public string overText;

	public void Execute() {
		GameOverEvent.Raise(overText);
	}


	private void Init() {
#if UNITY_EDITOR
		var guid = UnityEditor.AssetDatabase.FindAssets("t:StringEvent GameOverEvent").First();
		var path = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
		GameOverEvent = UnityEditor.AssetDatabase.LoadAssetAtPath<StringEvent>(path);
#endif
	}
}
