using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Buttonmanager : MonoBehaviour
{
    
    //Pause menu stuff:
    private void Start()
    {
        //pauseMenu.set
    }

    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene("MainMenu"); 
    }

    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnInstructionsButtonPressed()
    {

    }

    public void OnCreditsButtonPressed()
    {

    }
    
    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
