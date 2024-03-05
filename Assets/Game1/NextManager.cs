using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NextManager : MonoBehaviour
{
    public Button nextButton;

    private ScoreManager scoreManager;

    public AudioSource clickSfx;

    // Start is called before the first frame update
    void Start()
    {
        nextButton = GameObject.Find("Next").GetComponent<Button>();
        clickSfx = GameObject.Find("ClickSfx").GetComponent<AudioSource>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    public void NextGame()
    {
        clickSfx.Play();

        float fn = 0f;
        fn = (float)(scoreManager.Score / scoreManager.Num);

        if(fn > 3f)
        {
            SceneManager.LoadScene("HTP2", LoadSceneMode.Single);
        }
        else 
        {
            Debug.Log("Game over");
            SceneManager.LoadScene("OverMore", LoadSceneMode.Single);
        }
        
        //
    }
}
