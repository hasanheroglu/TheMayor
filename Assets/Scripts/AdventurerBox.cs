using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AdventurerBox : MonoBehaviour
{
	private Adventurer _adventurer;

	public GameObject adventurer;
	public TextMeshProUGUI name;
	public TextMeshProUGUI level;
	public TextMeshProUGUI salary;
	public TextMeshProUGUI daysToComplete;
	public GameObject daysToCompleteObject;
	public GameObject sendToQuest;
	public GameUIManager gameUIManager;

	private bool _onQuestState;

	private void Start()
	{
		gameUIManager = GameObject.Find("GameUIManager").GetComponent<GameUIManager>();
	}

	private void Update()
	{	
		if(_adventurer.onQuest)
			SetDaysToComplete(_adventurer.daysToComplete);
		
		if(_adventurer.onQuest && !_onQuestState)
			OnQuest();
		
		else if (!_adventurer.onQuest)
		{
			Free();
		}
	}

	public void SetAdventurer(GameObject adventurer)
	{
		this.adventurer = adventurer;
		_adventurer = adventurer.GetComponent<Adventurer>();
		SetAdventurerBox();
		sendToQuest.GetComponent<Button>().onClick.AddListener(() =>
		{
			gameUIManager.OpenQuestSelection(this.adventurer);
		});
	}

	private void SetAdventurerBox()
	{
		SetName(_adventurer.name);
		SetLevel(_adventurer.level);
		SetSalary(_adventurer.salary);
		_onQuestState = false;
	}

	private void SetName(string name)
	{
		this.name.text = name;
	}

	private void SetLevel(int level)
	{
		this.level.text = level.ToString();
	}

	private void SetSalary(int salary)
	{
		this.salary.text = salary.ToString();
	}

	private void SetDaysToComplete(int daysToComplete)
	{
		this.daysToComplete.text = _adventurer.GetComponent<Adventurer>().quest.name + "\n" + "Days To Complete" + "\n" + daysToComplete.ToString();
	}
	/*
	private void UpdateBox()
	{
		if(_adventurer.onQuest)
			SetDaysToComplete(_adventurer.daysToComplete);
		
		if(_adventurer.onQuest && !_onQuestState)
			OnQuest();
		
		else if (!_adventurer.onQuest)
		{
			Free();
		}
	}
	*/
	private void OnQuest()
	{
		_onQuestState = true;
		SetDaysToComplete(_adventurer.daysToComplete);
		daysToCompleteObject.SetActive(true);
		sendToQuest.SetActive(false);
	}

	private void Free()
	{
		daysToCompleteObject.SetActive(false);
		sendToQuest.SetActive(true);
		SetAdventurerBox();
	}
}
