using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float maxTime = 60f; // �ִ� �ð�
    public Image timeBar;
    public GameDirector director;

    private float currentTime;
    private bool isGameOver = false;

    private void Start()
    {
        currentTime = maxTime;
        timeBar = GameObject.Find("Timer").GetComponent<Image>();
        director = GameObject.Find("GameDirector").GetComponent<GameDirector>();

    }

    private void Update()
    {
        if (!isGameOver)
        {
            if (currentTime > 0f)
            {
                currentTime -= Time.deltaTime;
                UpdateTimeBar();
            }
            else
            {
                GameOver();
            }
        }
    }

    private void UpdateTimeBar()
    {
        float fillAmount = currentTime / maxTime;
        timeBar.fillAmount = fillAmount;
    }

    private void GameOver()
    {
        isGameOver = true;
        director.GameOver();
        // ���� ���� ó�� (���� ���� ǥ�� ��)
    }
}
