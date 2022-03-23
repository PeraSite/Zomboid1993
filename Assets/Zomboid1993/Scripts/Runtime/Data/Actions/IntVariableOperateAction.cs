using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class IntVariableOperateAction : ISelectAction {
	[HorizontalGroup(""), HideLabel]
	public IntVariable Variable;

	[HorizontalGroup("", 20), HideLabel]
	[ValueDropdown("@OperationType.Values")]
	public OperationType Operation = OperationType.SET;

	[HorizontalGroup("", 50), HideLabel]
	public int Value;

	public void Execute() {
		Variable.Value = Mathf.Clamp(Operation.Operate(Variable.Value, Value), 0, 100);
	}
}
