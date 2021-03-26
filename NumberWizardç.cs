using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardç : MonoBehaviour
{

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        int max = 1000;
        int min = 1;
        int guess = 500;
        Debug.Log("Welcome champ!");
        Debug.Log("Pick a number");
        Debug.Log("Highest number is " + max);
        Debug.Log("Lowest number is " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Press Up = higher, Press Down = Lower, Press Enter = Correct");
        max += 1;
    }

    void NextGuess()
    {

        guess = (max + min) / 2;
        Debug.Log("Is your number Higher or Lower than " + guess);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            min = guess;
           NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow Pressed");
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Your number is " + guess!);
            StartGame();
        }
    }

}
