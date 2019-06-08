using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestFactory : MonoBehaviour
{
	public GameObject quest;
	public List<GameObject> quests = new List<GameObject>();	
	public GameObject nameGenerator;

	
	private int _questCount;

	public GameObject CreateQuest()
	{
		GameObject newQuest = Instantiate(quest);
		var name = nameGenerator.GetComponent<NameGenerator>().GenerateName();
		var difficulty = nameGenerator.GetComponent<NameGenerator>().GenerateDifficulty();
		newQuest.GetComponent<Quest>().SetQuest( name + "'s Demand", name + " has a demand.", difficulty, _questCount);
		quests.Add(newQuest);
		_questCount++;
		return newQuest;
	}

	public int GetQuestCount()
	{
		return _questCount;
	}
}
