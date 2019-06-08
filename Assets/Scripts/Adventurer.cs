using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Attribute{ Strong, Coward, Liar };
public class Adventurer : MonoBehaviour
{

	public int index;
	public string name;
	public Attribute attribute;
	public int level = 1;
	public int experience = 0;
	public int salary;
	public int daysToComplete;
	public Quest quest;
	public bool onQuest;
	
	private int _nextLevelExperience;
	private int _physicalPoint;
	private int _socialPoint;
	private int _intellectualPoint;

	void Update()
	{
		if(daysToComplete == 0 && onQuest){
			EarnExperience();
			onQuest = false;
			quest = null;
		}
		if(experience >= _nextLevelExperience)
			LevelUp();
		
	}

	public void SetAdventurer(string name, int index)
	{
		this.name = name;
		this.index = index;
		level = 1;
		onQuest = false;
		SetRandomAttributePoints();
		SetSalary();
		SetNextLevelExperience();
	}

	private void LevelUp()
	{
		level++;
		experience -= _nextLevelExperience;
		_nextLevelExperience *= level;
	}

	public void DoQuest(Quest quest)
	{
		SetQuest(quest);
		onQuest = true;
		daysToComplete = this.quest.CompleteQuest() - _physicalPoint + _socialPoint - _intellectualPoint;
		if (daysToComplete <= 0)
			daysToComplete = 1;
	}

	public void EarnExperience()
	{
		experience += quest.difficulty * 5;
	}

	public void SetQuest(Quest quest)
	{
		this.quest = quest;
	}

	private void SetSalary()
	{
		System.Random rand = new System.Random();
		salary = rand.Next(100, 200);
		salary += level * ((salary * (-_socialPoint)) / 10);
	}

	private void SetNextLevelExperience()
	{
		_nextLevelExperience = 10;
		_nextLevelExperience -= _intellectualPoint;
	}

	private void SetRandomAttributePoints()
	{
		System.Random rand = new System.Random();
		_physicalPoint = rand.Next(-2,2);
		_socialPoint = rand.Next(-2, 2);
		_intellectualPoint = rand.Next(-2, 2);
	}
}
