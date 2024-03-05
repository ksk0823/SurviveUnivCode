using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public int score;
    private TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 100;
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void ViewFinalScore()
    {
        TimerTwo timeBar = GameObject.Find("Timer").GetComponent<TimerTwo>();

        if(timeBar.currentTime<30 && timeBar.currentTime>=25)
        {
            score = 100;
        } 
        else if (timeBar.currentTime<25 && timeBar.currentTime>=20)
        {
            score = 80;
        }
        else if (timeBar.currentTime < 20 && timeBar.currentTime >= 15)
        {
            score = 60;
        }
        else if (timeBar.currentTime < 15 && timeBar.currentTime >= 7)
        {
            score = 50;
        }
        else 
        {
            score = 0;
        }


        scoreText.text = score.ToString();
    }
}
