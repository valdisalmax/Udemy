using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    int tries = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than:" + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Your number is higher than " + guess + ".");
            min = guess;
            guess = (max + min) / 2;
            tries++;
            Debug.Log("Is your number " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Your number is lower than " + guess + ".");
            max = guess;
            guess = (max + min) / 2;
            tries++;
            Debug.Log("Is your number " + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed the right number, your number is " + guess + " and it took me " + tries + " tries!!");
        }
    }
}
