using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManagerScript : MonoBehaviour
{
    //Attaching script-components to be able to access variables of other scripts
    public Killbox killbox;
    public killPlayer killPlayer;
    public ScoreScript scoreScript;

    //Attaching Game Objects
    public GameObject GameOverPanel;
    public GameObject gameCharacter1;

    //Declaring Variable to break the Update cycle once one of the conditions inside is met
    private bool _PlayerDead = false;


    // Start is called before the first frame update
    void Start()
    {
        //Resets game states to start the game
        GameOverPanel.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (_PlayerDead == false)
        {
            //Game Over if player falls off the ground
            if (killbox.IsDead == true)
            {
                GameOverPanel.SetActive(true);
                Debug.Log("Character is dead!");
                _PlayerDead = true;
                Time.timeScale = 0;
            }
            //Game Over if player gets hit by a stone
            else if (gameCharacter1.activeInHierarchy == false)
            {
                GameOverPanel.SetActive(true);
                Debug.Log("Character is dead!");
                _PlayerDead = true;
                Time.timeScale = 0;
            }
            //Game Won if the player catched x amount of tomatoes
            else if (scoreScript.scoreCount == 50)
            {
                GameOverPanel.SetActive(true);
                Debug.Log("YOU WON!");
                Time.timeScale = 0;
                _PlayerDead = true;
            }

        }

        

    }

    
}
