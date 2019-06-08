using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameGenerator : MonoBehaviour
{

	private string[] firstSyllable = new [] {"Bra", "Stu", "Kra", "Make", "Tre", "Jase", "Ero", "Aye"};
	private string[] secondSyllable = new [] {"ken", "veo", "lio", "non", "mec", "kel", "mul", "nep"};

	public string GenerateName()
	{
		var name = "";
		System.Random rand = new System.Random();
		name = firstSyllable[rand.Next(0, 7)];
		name += secondSyllable[rand.Next(0, 7)];

		return name;
	}

	public int GenerateDifficulty()
	{
		System.Random rand = new System.Random();
		return rand.Next(1, 9);
	}

}
