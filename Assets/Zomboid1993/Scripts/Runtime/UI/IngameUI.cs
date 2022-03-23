using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

public class IngameUI : SerializedMonoBehaviour {
	[Header("UI 요소")]
	[LabelText("플레이어의 초상화 이미지")]
	public Image Portrait;

	[LabelText("삽화 이미지")]
	public Image Illustrate;

	[LabelText("선택지 설명 텍스트")]
	public TextMeshProUGUI Description;

	[AssetsOnly]
	[LabelText("선택지 버튼 프리팹")]
	public SelectButton ButtonPrefab;

	[LabelText("선택지 버튼 부모 트랜스폼")]
	public Transform SelectButtonParent;

	[LabelText("자원 게이지 목록")]
	public Dictionary<StatType, Image> StatGauge = new();


	[Header("이벤트")]
	public StringEvent OnNextStoryEvent;


	[Header("데이터")]
	public StoryDatabase StoryDatabase;

	private List<SelectButton> Buttons = new();

	private void OnEnable() {
		OnNextStoryEvent.Register(OnNextStory);

		OnNextStoryEvent.Raise("1");
	}

	private void OnDisable() {
		OnNextStoryEvent.Unregister(OnNextStory);
	}

	private void OnNextStory(string storyID) {
		var story = StoryDatabase.StoryList.FirstOrDefault(s => s.ID == storyID);
		if (story.SafeIsUnityNull()) return;
		RefreshUI(story);
	}

	private void RefreshUI(StoryData data) {
		//TODO: 삽화 설정
		Description.text = data.Description;
		foreach (var selectButton in Buttons) {
			Destroy(selectButton.gameObject);
		}
		Buttons.Clear();
		data.Options
			.Select(selectData => {
				var button = Instantiate(ButtonPrefab, SelectButtonParent);
				button.Init(selectData);
				return button;
			})
			.ForEach(button => Buttons.Add(button));
	}

	public void SetStatGauge(StatType Type, float percent) {
		StatGauge[Type].fillAmount = percent;
	}


	[Button]
	public void ChangePortrait() { }
}

public enum StatType {
	HEALTH,
	HUNGER,
	MONEY,
	WEAPON
}
