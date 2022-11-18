using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise4 : MonoBehaviour
{
    public TextMeshProUGUI turnText;

    //Turs you have
    private int Turns = 10;
    private int guessLetter; 

    //To control wwhen you can click de bottons
    private bool Click = true;

    //Random answer
    private int randomNumber;
    public GameObject[] randomGuess;

   
    //Counters of correct and incorrect answers
    private int correctCounter;
    private int incorrectCounter;

    //Answers that apier at the end (incorrect and incorrect)
    public TextMeshProUGUI correctText;
    public TextMeshProUGUI incorrectText;

    private IEnumerator RandomOption()
    {
        Click = false;
        yield return new WaitForSeconds(1f);
        randomNumber = Random.Range(0, 2);
        randomGuess[randomNumber].SetActive(true);

        //A point will be add to our correct counter 
        if (randomNumber == guessLetter)
        {
            correctCounter++;
        }
        //A point will be add to our incorrect counter
        else
        {
            incorrectCounter++;
        }

        //Wen the turns are over, they shoud appier the correct amd incorrect answers
        if (Turns == 0)
        {
          
            randomGuess[randomNumber].SetActive(false);
            correctText.gameObject.SetActive(true);
            incorrectText.gameObject.SetActive(true);
            correctText.text = $"You guess {correctCounter} correctly";
            incorrectText.text = $"You guess {incorrectCounter} incorrectly";

        }

        Click = true;
    }

    //Button (options bitui 0 ana 1)
    public void Button(int number)
    {
        if (Turns > 0 && Click)
        {
            randomGuess[randomNumber].SetActive(false);
            guessLetter = number; 
            Turns--;
            turnText.text = Turns.ToString();
            StartCoroutine(RandomOption());
        }
    }
   

   
}
