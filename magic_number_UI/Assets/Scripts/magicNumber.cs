using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class magicNumber : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessNum;
    int guess, lastGuess;

    List<int> guessList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max +1);
        guessNum.text = guess.ToString();
    }

    public void higherPressed()
    {
        min = guess +1;
        NextGuess();
    }

    public void lowerPressed()
    {
        max = guess -1;
        NextGuess();
    }
}
