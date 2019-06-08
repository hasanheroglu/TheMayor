using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestBox : MonoBehaviour
{

	public GameObject quest;
	public TextMeshProUGUI name;
	public TextMeshProUGUI description;
	public TextMeshProUGUI difficulty;

	public void SetQuest(GameObject quest)
	{
		this.quest = quest;
		Quest newQuest = this.quest.GetComponent<Quest>(); 
		SetName(newQuest.name);
	    SetDescription(newQuest.description);
	    SetDifficulty(newQuest.difficulty);
	}

	private void SetName(string name){
		this.name.text = name;
	}
	private void SetDescription(string description){
		this.description.text = description;
	}
	private void SetDifficulty(int difficulty){
		this.difficulty.text = difficulty.ToString();
	}
}
