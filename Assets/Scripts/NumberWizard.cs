using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame () {

		max = 1000;
		min = 1;
		guess = 500;

		print ("Welcome to Number Wizard");
		print ("Pick a number in your head!");
		print ("Highest number you can pick is " + max + " and the lowest is " + min);
		print ("Is the number higher or lower than " + guess + "? \nUp Arrow for higher, Down Arrow for lower, Return for equal");

		max = max + 1;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess; 
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");
			StartGame();
		}
	}

	void NextGuess () {
		guess = (max + min) / 2;
		print ("Is the number higher or lower than " + guess + "? \nUp Arrow for higher, Down Arrow for lower, Return for equal");
	}
}
