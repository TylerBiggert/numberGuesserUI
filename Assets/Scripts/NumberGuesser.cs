﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberGuesser : MonoBehaviour
{


    [SerializeField] int max = 1000;
    [SerializeField] int min = 1;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;


    // Called before the first frame update
    void Start()
    {
        StartGame();
    }



    void StartGame ()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }


    void NextGuess()
    {
        guess = Random.Range(min, max+1);
        guessText.text = guess.ToString();
    }
}
