using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;

public class SetBoolVariableAction : ISelectAction {
	[HorizontalGroup, HideLabel]
	public BoolVariable Variable;

	[HorizontalGroup, HideLabel]
	public bool Value;

	public void Execute() {
		Variable.Value = Value;
	}
}
