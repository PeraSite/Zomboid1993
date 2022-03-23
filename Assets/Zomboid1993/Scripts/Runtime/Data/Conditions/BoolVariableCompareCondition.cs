using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;

public class BoolVariableCompareCondition : ISelectCondition {
	[HorizontalGroup, HideLabel]
	public BoolVariable Variable;

	[HorizontalGroup, HideLabel]
	public bool Value;

	public bool Check() {
		return Variable.Value == Value;
	}
}
