using System;
using System.Collections;
using Sirenix.OdinInspector;
using UnityEngine;

[Serializable]
public struct CompareType {
	public static readonly CompareType EQUALS = new() {Name = "=="};
	public static readonly CompareType LESS = new() {Name = "<"};
	public static readonly CompareType MORE = new() {Name = ">"};
	public static readonly CompareType EQUALS_OR_LESS = new() {Name = "<="};
	public static readonly CompareType EQUALS_OR_MORE = new() {Name = ">="};

	[HideInInspector]
	public string Name;

	public bool Compare(int a, int b) {
		if (Equals(EQUALS))
			return a == b;
		if (Equals(LESS))
			return a < b;
		if (Equals(MORE))
			return a > b;
		if (Equals(EQUALS_OR_LESS))
			return a <= b;
		if (Equals(EQUALS_OR_MORE))
			return a >= b;
		return false;
	}


	public static IEnumerable Values = new ValueDropdownList<CompareType> {
		{EQUALS.Name, EQUALS},
		{MORE.Name, MORE},
		{LESS.Name, LESS},
		{EQUALS_OR_MORE.Name, EQUALS_OR_MORE},
		{EQUALS_OR_LESS.Name, EQUALS_OR_LESS},
	};
}
