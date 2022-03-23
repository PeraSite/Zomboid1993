using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine.UI;

public class PlayUI : SerializedMonoBehaviour {
	public Image Portrait;
	public Dictionary<StatType, Image> StatGauge = new();

	[Button]
	public void SetStatGauge(StatType Type, float percent) {
		StatGauge[Type].fillAmount = percent;
	}


	[Button]
	public void ChangePortrait() {

	}
}

public enum StatType {
	HEALTH,
	HUNGER,
	MONEY,
	WEAPON
}
