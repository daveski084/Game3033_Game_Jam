using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Buttonmanager : MonoBehaviour
{
    

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
        SceneManager.LoadScene("Instructions"); 
    }

    public void OnCreditsButtonPressed()
    {
        SceneManager.LoadScene("Credits"); 
    }
    
    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitButtonPressed()
    {
        Application.Quit(); 
    }

    public void OnMainMenuPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
