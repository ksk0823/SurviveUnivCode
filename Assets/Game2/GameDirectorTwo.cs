using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirectorTwo : MonoBehaviour
{
    private bool isGameOver;

    public GameObject player;

    public ScoreController score;

    public SpriteRenderer scoreImage;

    public GameObject nt;

    private void Start()
    {
        isGameOver = false;
        player = GameObject.Find("player");
        score = GameObject.Find("Score").GetComponent<ScoreController>();
        scoreImage = GameObject.Find("nowScore").GetComponent<SpriteRenderer>();
        scoreImage.enabled = false;
        nt = GameObject.Find("Next");
        nt.SetActive(false);

    }

    private void Update()
    {
        if (isGameOver)
        {
            // ???? ???? ?? ?????? ?????? ???? Time.timeScale ???? 0???? ????
            Time.timeScale = 0f;
            AudioSource bgm = GameObject.Find("BGM").GetComponent<AudioSource>();
            bgm.Stop();
            AudioSource clockbgm = GameObject.Find("clockSFX").GetComponent<AudioSource>();
            clockbgm.Stop();
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        score.ViewFinalScore();
        player.SetActive(false);
        scoreImage.enabled = true;
        nt.SetActive(true);
    }
}
