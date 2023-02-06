using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    //Loads the Game Scene
    public void StartGame()
    {
        SceneManager.LoadScene("Scene01");
    }

    //Loads the Main Menu Scene
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


    
}
