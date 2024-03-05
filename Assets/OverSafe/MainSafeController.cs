using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainSafeController : MonoBehaviour
{
    public Button nextButton;

    public AudioSource clickSfx;

    // Start is called before the first frame update
    void Start()
    {
        nextButton = GameObject.Find("Main").GetComponent<Button>();
        clickSfx = GameObject.Find("ClickSfx").GetComponent<AudioSource>();
    }

    public void NextGame()
    {
        clickSfx.Play();
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        //
    }
}
