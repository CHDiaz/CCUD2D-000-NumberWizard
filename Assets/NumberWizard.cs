using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 Number Wizard is a simple game where a player will need to mentally select a number that is between the displayed range. 
 Afterwards, the wizard will attempt to guess the number using binary search and hints from the player if their guess is higher or lower than their number.
 */
public class NumberWizard : MonoBehaviour
{
    //max, min, and guess are variables to be used in NumberWizard. max will be used to indicate the highest end of our range. min will indicate the lowest end of our range. guess will be our current guessing number, which will always be min + max /2
    int max = 1001;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        //The StartGame() function contains the text required to start a game of NumberWizard.
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        // If the Up arrow is pressed on the keyboard, then this input from the player will indicate that the guess they were displayed, is a number lower than their number.
        // Our previous guess will become the new min, and our new guess will be calculated.
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            Debug.Log("You selected the UP arrow indicating your number is higher than: " + guess + ".\n");
            min = guess;
            NextGuess();
        }
        // Otherwise, if the Down arrow is pressed on the keyboard, then this input from the player will indicate that the guess they were displayed, is a number higher than their number.
        // Our previous guess will become the new max, and our new guess will be calculated.
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.\n");
            max = guess;
            NextGuess();
        }
        // Finally, If the Enter/Return key is pressed on the keyboard, then this input from the player will indicate that the guess they were displayed, is the number they selected.
        // We shall brag to the player and thank them for playing, display some seperating lines and start the game over.
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Awesome! Your number was: "+ guess + ".\n");
            Debug.Log("I r smart!\n");
            Debug.Log("Thanks for playing!\n");
            print("========================================================================================\n");
            print("========================================================================================\n");
            print("========================================================================================\n");
            StartGame();
        }
    }

    //This function is used to indicate the start of a game of NumberWizard. It will display to the player the rules, as well a starting guess.
    //This function will also reset the bounds to 1 and 10001, as well as setting the gues to the starting value of min + max/2
    void StartGame() {
        max = 1001;
        min = 1;
        guess = ((min + max) / 2);
        Debug.Log("Welcome Player! This is NumberWizard!\n");
        Debug.Log("In order to play, please select a number.\n");
        Debug.Log("The HIGHEST you can pick is: " + (max-1) + ".\n");
        Debug.Log("The LOWEST you can pick is: " + min + ".\n");
        Debug.Log("Please tell me if your number is higher or lower than our guess?\n");
        Debug.Log("Push UP = Guess is HIGHER than your number.\n");
        Debug.Log("Push DOWN = Guess is LOWER than your number.\n");
        Debug.Log("Push ENTER = Guess is CORRECT and is your number!\n");
        Debug.Log("Our current guess is: " + guess + ".\n");
    }

    //This function removes the slighy redunant code of caculating our next guess and displaying our guess to the player.
    void NextGuess() {
        guess = ((min + max) / 2);
        Debug.Log("Our current guess is: " + guess + ".\n");
    }
}
