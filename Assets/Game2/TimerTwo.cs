using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerTwo : MonoBehaviour
{
    public float maxTime = 30f; // 최대 시간
    public Image timeBar;
    public GameDirectorTwo director;

    public float currentTime;
    private bool isGameOver = false;


    private void Start()
    {
        currentTime = maxTime;
        timeBar = GameObject.Find("Timer").GetComponent<Image>();
        director = GameObject.Find("GameDirector").GetComponent<GameDirectorTwo>();
    }

    private void FixedUpdate()
    {
        if (!isGameOver)
        {
            if (currentTime > 0f)
            {
                currentTime -= 0.02f;
                UpdateTimeBar();
            }
            else
            {
                GameOver();
            }
        }

        if (currentTime > 4f && currentTime < 10f)
        {
            clockController ct = GameObject.Find("clock").GetComponent<clockController>();
            if (!ct.isRinging)
            {
                ct.RingClock();
            }
        }
    }

    public void UpdateTimeBar()
    {
        float fillAmount = currentTime / maxTime;
        timeBar.fillAmount = fillAmount;
    }

    public void GameOver()
    {
        isGameOver = true;
        director.GameOver();
        // 게임 종료 처리
    }
}
