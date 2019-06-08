using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest: MonoBehaviour
{
	public int index;
	public string name;
	public string description;
	public int difficulty;

	public void SetQuest(string name, string description, int difficulty, int index){
		this.name = name;
		this.description = description;
		this.difficulty = difficulty;
		this.index = index;
	}

	public int CompleteQuest()
	{
		System.Random rand = new System.Random();
		return rand.Next(1,3) + difficulty;
	}

	
}
