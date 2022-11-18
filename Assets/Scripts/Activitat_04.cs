using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Activitat_04 : MonoBehaviour
{
    public TextMeshProUGUI roundText;
    private int currentRound = 10;
    private int guessNumber; 

    //Random answer
    private int randomNumber;
    public GameObject[] randomGuess;

    //Variable to control when we can click the answer
    private bool canClick = true; 

    //Counters of correct and incorrect answers
    private int correctCounter;
    private int incorrectCounter;

    //Text to show thw answer
    public TextMeshProUGUI answerCounterText;


    //Function to select an answer with the buttons
    public void ButtonAnswer(int number)
    {
        if (currentRound > 0 && canClick)
        {
            guessNumber = number; 
            currentRound--;
            roundText.text = "Round: "+currentRound.ToString();
            StartCoroutine(RandomizeAnswer());
        }
    }

    //Function to randomize an answer and add a cooldown between rounds
    private IEnumerator RandomizeAnswer()
    {
        canClick = false;
        yield return new WaitForSeconds(1f);
        //Random answer is generated
        randomNumber = Random.Range(0, 2); 

        //If we guess an answer, a point will be add to the correct answers counter
        if (randomNumber == guessNumber)
        {
            correctCounter++;
        }
        //If not a point will de add to the incorrect answers counter
        else
        {
            incorrectCounter++;
        }
        //If we reach round 0 we shoe the answer
        if (currentRound == 0)
        {
            yield return new WaitForSeconds(1f); //It shows the final answer before displaying the results       
            answerCounterText.text = $"You have guess {correctCounter} answers correctly and {incorrectCounter} answers incorrectly";
        }
        canClick = true;
    }   
}
