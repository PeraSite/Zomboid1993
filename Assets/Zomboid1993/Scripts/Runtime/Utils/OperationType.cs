using System;
using System.Collections;
using Sirenix.OdinInspector;
using UnityEngine;

[Serializable]
public struct OperationType {
	public static readonly OperationType SET = new() {Name = "="};
	public static readonly OperationType ADD = new() {Name = "+"};
	public static readonly OperationType SUB = new() {Name = "-"};
	public static readonly OperationType MUL = new() {Name = "×"};
	public static readonly OperationType DIV = new() {Name = "÷"};

	[HideInInspector]
	public string Name;

	public int Operate(int a, int b) {
		if (Equals(SET))
			return b;
		if (Equals(ADD))
			return a + b;
		if (Equals(SUB))
			return a - b;
		if (Equals(MUL))
			return a * b;
		if (Equals(DIV))
			return a / b;
		return a;
	}


	public static IEnumerable Values = new ValueDropdownList<OperationType> {
		{SET.Name, SET},
		{ADD.Name, ADD},
		{SUB.Name, SUB},
		{MUL.Name, MUL},
		{DIV.Name, DIV},
	};
}
