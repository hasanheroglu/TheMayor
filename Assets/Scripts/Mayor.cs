using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mayor : MonoBehaviour {

	string name;
	int gold;
	List <Quest> quests;
	List <Adventurer> adventurers;

	Mayor(){
		name = "Not available";
		gold = 0;
	}

	Mayor(string name, int gold){
		this.name = name;
		this.gold = gold;
	}

}
