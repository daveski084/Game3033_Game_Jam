using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float count = 120.0f;
    public Text timerText;

    // Update is called once per frame
    void Update()
    {
        if (count > 0)
        {
            count -= Time.deltaTime;
        }
        else
        {
            count = 0;
            SceneManager.LoadScene("Death"); 
        }

        DisplayTime(count); 
    }

    void DisplayTime(float _timeToDisplay)
    {
        if(_timeToDisplay < 0)
        {
            _timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(count / 60);
        float seconds = Mathf.FloorToInt(count % 60);

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
