using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    int tries;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welkom bij de nummer tovenaar");
        Debug.Log("Kies een nummer maar vertel mij niet wat je gekozen hebt...");
        Debug.Log("Het hoogste getal wat je kan kiezen is: " + max);
        Debug.Log("Het kleinste getal wat je kan kiezen is: " + min);
        Debug.Log("Zeg me of je getal groter of kleiner is dan:" + guess);
        Debug.Log("Pijltje Omhoog = Hoger, Pijltje Omlaag = Lager, Druk op Enter = Juist geraden");
        max = max + 1;
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Ik heb het juiste nummer geraden, het nummer is " + guess + " en het koste me " + tries + " beurten!!");
            //Debug.Log("Druk nogmaals op Enter om een nieuw spel te starten.");
            StartGame();
         }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        tries++;
        Debug.Log("Is het hoger of lager dan " + guess + "?");
    }
}
