using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //Variable to store Score
    public int scoreCount; 
    //Variable to display text
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Converts the int-value of "scoreCount" to a string and stores it in the text variable "score"
        score.text = scoreCount.ToString();
    }

    //Increases the value of "scoreCount" by 1 each time this function is called
    public void IncreaseTomatoCount()
    {
        scoreCount++;
    }
}
