using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame()
	{
		max = 1000;
		min = 1;
		guess = Random.Range(min, max);
		
		print("=========================");
		print("Welcome to Number Wizard");
		print("Pick a number in your head, but don't tell me");
		
		print("The highest number you can pick is " + max);
		print("The lowest number you can pick is " + min);
		
		print("Is your number higher or lower than " + guess + "?");
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//print("Up arrow pressed");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print("Down arrow pressed");	
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");	
			StartGame();
		}
	}
	
	void NextGuess(){
		//guess = (max + min) / 2; //halfway between the max and the min
		guess = Random.Range(min, max) + 1;
		print("Is your number " + guess + "?");
	}
}
