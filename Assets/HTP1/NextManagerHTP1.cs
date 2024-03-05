using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NextManagerHTP1 : MonoBehaviour
{
    public Button nextButton;

    public AudioSource clickSFX;

    // Start is called before the first frame update
    void Start()
    {
        nextButton = GameObject.Find("Next").GetComponent<Button>();
        clickSFX = GameObject.Find("NextSfxHTP1").GetComponent<AudioSource>();
    }

    public void NextGame()
    {
        if (clickSFX != null)
            clickSFX.Play();

        SceneManager.LoadScene("Game1", LoadSceneMode.Single);
        //
    }
}
