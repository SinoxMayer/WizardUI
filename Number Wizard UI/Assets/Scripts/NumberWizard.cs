using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NumberWizard : MonoBehaviour
{

    [SerializeField]int max;
    [SerializeField]int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    //int temp;
    //List<int> randomNumberCount = new List<int>();


    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {

        NextGuess();
       
        max = max + 1;
    
    }

    // Update is called once per frame
    void Update()
    {

        



    }

    public void OnPressHigher()
    {
        min = guess++;
        NextGuess();
    }
    public void OnPressLower()
    {
        max = guess--;
        NextGuess();
    }
    void NextGuess()
    {
        //temp = Random.Range(min, max);

        //if (randomNumberCount.Contains(temp))
       // {
            //NextGuess();
        // }
        // randomNumberCount.Add(temp);
        // guess = temp;

        guess = Random.Range(min,max);
        //guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }
}
