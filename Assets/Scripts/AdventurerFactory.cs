using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventurerFactory : MonoBehaviour {

	public GameObject adventurer;
	public GameObject nameGenerator;
	
	private List<GameObject> _adventurers = new List<GameObject>();
	private int _adventurerCount;

	public GameObject CreateAdventurer()
	{
		GameObject newAdventurer = Instantiate(adventurer);
		newAdventurer.GetComponent<Adventurer>().SetAdventurer(nameGenerator.GetComponent<NameGenerator>().GenerateName(), _adventurerCount);
		_adventurers.Add(newAdventurer);
		_adventurerCount++;
		return newAdventurer;
	}

	public int GetAdventurerCount()
	{
		return _adventurerCount;
	}
}
