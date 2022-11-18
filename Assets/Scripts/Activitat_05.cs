using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Activitat_05 : MonoBehaviour
{
    //Variable to input a year
    public TMP_InputField yearInput;
    private int year;

    //Variables to show an image 
    public Image animalImage;
    public Sprite[] animalSprite;
    private int animalYear;

    //Variables to give an answer
    public TextMeshProUGUI animalText;
    public string[] animalTextArray;

    void Update()
    {
        //If we use the enter key ant the input field isnt empty
        if (Input.GetKeyDown("return") && yearInput.text != "")
        {
            //We convert the string in the input field to an int
            year = int.Parse(yearInput.text); 
            //We substract the year by 12 and get the remainder
            animalYear = year % 12;
            //We show the correct answer
            animalImage.sprite = animalSprite[animalYear];
            animalText.text = animalTextArray[animalYear];
        }
    }
}
