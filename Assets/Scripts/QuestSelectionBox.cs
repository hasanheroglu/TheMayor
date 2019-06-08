using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;


public class QuestSelectionBox : QuestBox
{
	public GameObject sendToQuest;

	private void Start()
	{
		sendToQuest.GetComponent<Button>().onClick.AddListener(SendToQuest);
	}

	private void SendToQuest()
	{
		var adventurer = GetComponentInParent<QuestSelection>().adventurer;

		if (adventurer.GetComponent<Adventurer>().onQuest)
		{
			//OnQuestError;
			return;
		}
		
		adventurer.GetComponent<Adventurer>().DoQuest(this.quest.GetComponent<Quest>());
		this.GetComponentInParent<ScrollManager>().RemoveBox(this.transform.GetSiblingIndex());
		Destroy(this.gameObject);
	}
}
