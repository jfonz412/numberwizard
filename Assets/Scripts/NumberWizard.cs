using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Welcome to Number Wizard");
		print("Pick a number in your head, but don't tell me");
		
		int max = 1000;
		int min = 1;
		
		print("The highest number you can pick is " + max);
		print("The lowest number you can pick is " + min);
		
		print("Is your number higher or lower than 500?");
		print("Press the Up arrow for higher");
		print("Press the Down arrow for lower");
		print("Press enter for equals");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
