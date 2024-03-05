using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartButtonManager : MonoBehaviour
{
    public Button startButton;
    public AudioSource bgm;
    public AudioSource buttonSFX;
    public GameObject[] objectsActivate; // ???? ???? ?? ???????? ???? ??????????

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        startButton = GameObject.Find("StartButton").GetComponent<Button>();
        buttonSFX = GameObject.Find("ButtonSFX").GetComponent<AudioSource>();
        bgm = GameObject.Find("BGM").GetComponent<AudioSource>();

        foreach (GameObject obj in objectsActivate)
        {
            obj.SetActive(false);
        }   
    }

    public void playSFX()
    {
        buttonSFX.Play();
    }

    public void StartGame()
    {
        Debug.Log("OK");

        Time.timeScale = 1f;

        //buttonSFX.Play();

        foreach (GameObject obj in objectsActivate)
        {
            obj.SetActive(true);
        }

        
        bgm.Play();

        // ???? ????????
        startButton.interactable = false;
        GameObject st = GameObject.Find("StartButton");
        st.SetActive(false);
    }
}
