using System;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
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

	public GameObject HurtImage;
	public GameObject InjuryImage;
	public CanvasGroup BloodImage;

	[Header("이벤트")]
	public StringEvent OnNextStoryEvent;

	public IntEvent HealthChangedEvent;
	public IntEvent MentalChangedEvent;
	public IntEvent MoneyChangedEvent;
	public IntEvent WeaponChangedEvent;

	public BoolEvent HurtChangedEvent;
	public BoolEvent InjuryChangedEvent;

	[Header("데이터")]
	public StoryDatabase StoryDatabase;

	public List<Sprite> PlayerPortraitSprites;

	private List<SelectButton> Buttons = new();

	private void OnEnable() {
		OnNextStoryEvent.Register(OnNextStory);

		OnNextStoryEvent.Raise("1");

		HealthChangedEvent.Register(value => SetStatGauge(StatType.HEALTH, value / 100f));
		MentalChangedEvent.Register(value => SetStatGauge(StatType.MENTAL, value / 100f));
		MoneyChangedEvent.Register(value => SetStatGauge(StatType.MONEY, value / 100f));
		WeaponChangedEvent.Register(value => SetStatGauge(StatType.WEAPON, value / 100f));

		HurtChangedEvent.Register(value => {
			HurtImage.SetActive(value);
			BloodImage.alpha = value ? 1f : 0f;
			if (!Portrait.SafeIsUnityNull())
				Portrait.sprite = PlayerPortraitSprites[value ? 1 : 0];
		});
		InjuryChangedEvent.Register(value => InjuryImage.SetActive(value));
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
		if (data.Illustrate.SafeIsUnityNull()) {
			Illustrate.gameObject.SetActive(false);
		} else {
			Illustrate.gameObject.SetActive(true);
			Illustrate.sprite = data.Illustrate;
		}
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
		if (!StatGauge[Type].SafeIsUnityNull())
			StatGauge[Type].fillAmount = percent * 0.5f + 0.4f;
	}


	[Button]
	public void ChangePortrait() { }
}

public enum StatType {
	HEALTH,
	MENTAL,
	MONEY,
	WEAPON
}
