using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;

public class IntVariableCompareCondition : ISelectCondition {
	[HorizontalGroup(""), HideLabel]
	public IntVariable Variable;

	[HorizontalGroup("", 20), HideLabel]
	[ValueDropdown("@CompareType.Values")]
	public CompareType Compare = CompareType.EQUALS;

	[HorizontalGroup("", 50), HideLabel]
	public int Value;

	public bool Check() {
		return Compare.Compare(Variable.Value, Value);
	}
}
