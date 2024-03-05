using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextButtonControllerGTwo : MonoBehaviour
{

    public Button nextButton;

    private ScoreController finalScore;

    public AudioSource buttonSFX;

    // Start is called before the first frame update
    void Start()
    {
        nextButton = GameObject.Find("Next").GetComponent<Button>();
        finalScore  = GameObject.Find("Score").GetComponent<ScoreController>();
        buttonSFX = GameObject.Find("ButtonSFX").GetComponent<AudioSource>();
    }

    public void ButtonClick()
    {
        playSFX();

        //Invoke("ShowResult", 0.3f);
        ShowResult();

    }

    public void playSFX()
    {
        buttonSFX.Play();
    }

    public void ShowResult()
    {
        int score = finalScore.score;
        

        if (score >= 80)
        {
            SceneManager.LoadScene("OverBest", LoadSceneMode.Single);
        }
        else if (score < 80 && score >= 50)
        {
            SceneManager.LoadScene("OverSafe", LoadSceneMode.Single);
        }
        else
        {
            SceneManager.LoadScene("OverMore", LoadSceneMode.Single);
        }
    }
}
