using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Danger{NONE, LOW, MODERATE, HIGH};

public class Village : MonoBehaviour {

	string name; 
	int population;
	int attraction;
	Danger danger;

	Village(){
		name = "Not available";
		population = 0;
		attraction = 0;
		danger = Danger.NONE;
	}

	Village(string name, int population, int attraction, Danger danger){
		this.name = name;
		this.population = population;
		this.attraction = attraction;
		this.danger = danger;
	}

}
