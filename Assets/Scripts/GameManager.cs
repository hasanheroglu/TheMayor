using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject gameUIManager;
	public GameObject questFactory;
	public GameObject adventurerFactory;
	public int days = 1;
	
	public void AddQuest(){
		GameObject quest = questFactory.GetComponent<QuestFactory>().CreateQuest();
		gameUIManager.GetComponent<GameUIManager>().AddQuest(quest, quest.GetComponent<Quest>().index);
		gameUIManager.GetComponent<GameUIManager>().AddQuestSelection(quest, quest.GetComponent<Quest>().index);
	}

	public void AddAdventurer()
	{
		GameObject adventurer = adventurerFactory.GetComponent<AdventurerFactory>().CreateAdventurer();
		gameUIManager.GetComponent<GameUIManager>().AddAdventurer(adventurer, adventurer.GetComponent<Adventurer>().index);
	}

	public void StartTheDay()
	{
		
	}
	
	public void EndTheDay()
	{
		days++;
		CalculateDaysToComplete();
		//ShowEndDayUI();
	}

	private void CalculateDaysToComplete()
	{
		foreach (var adventurer in GameObject.FindGameObjectsWithTag("Adventurer"))
		{
			adventurer.GetComponent<Adventurer>().daysToComplete--;
		}
	}
}
