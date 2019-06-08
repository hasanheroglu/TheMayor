using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour
{

	public GameObject questSelection;

	public GameObject questScrollContent;
	public GameObject adventurerScrollContent;
	public GameObject questSelectionContent;

	public GameObject questBox;
	public GameObject questSelectionBox;
	public GameObject adventurerBox;

	public void AddQuest(GameObject quest, int questCount){
		var newQuestBox = Instantiate(questBox, questScrollContent.GetComponent<Transform>());
		newQuestBox.GetComponent<QuestBox>().SetQuest(quest);
		questScrollContent.GetComponent<ScrollManager>().SetBoxPosition(newQuestBox);
	}

	public void AddAdventurer(GameObject adventurer, int adventurerCount){
		var newAdventurerBox = Instantiate(adventurerBox, adventurerScrollContent.GetComponent<Transform>());
		newAdventurerBox.GetComponent<AdventurerBox>().SetAdventurer(adventurer);
		adventurerScrollContent.GetComponent<ScrollManager>().SetBoxPosition(newAdventurerBox);
	}
	
	public void AddQuestSelection(GameObject quest, int questCount){
		var newQuestSelectionBox = Instantiate(questSelectionBox, questSelectionContent.GetComponent<Transform>());
		newQuestSelectionBox.GetComponent<QuestSelectionBox>().SetQuest(quest);
		questSelectionContent.GetComponent<ScrollManager>().SetBoxPosition(newQuestSelectionBox);
	}

	public void OpenQuestSelection(GameObject adventurer)
	{
		questSelection.SetActive(true);
		questSelectionContent.GetComponent<QuestSelection>().adventurer = adventurer;
	}
	
	public void CloseQuestSelection()
	{
		questSelection.SetActive(false);
	}
	
}
