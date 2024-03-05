using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartManager : MonoBehaviour
{
    public Button startButton;
    public AudioSource bgm;
    public AudioSource clickSfx;
    public GameObject[] objectsActivate; // ���� ���� �� Ȱ��ȭ�� ���� ������Ʈ��

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        startButton = GameObject.Find("Start").GetComponent<Button>();
        bgm = GameObject.Find("BGM").GetComponent<AudioSource>();
        clickSfx = GameObject.Find("ClickSfx").GetComponent<AudioSource>();

        foreach (GameObject obj in objectsActivate)
        {
            obj.SetActive(false);
        }
    }

    public void StartGame()
    {
        Debug.Log("OK");

        clickSfx.Play();

        foreach (GameObject obj in objectsActivate)
        {
            obj.SetActive(true);
        }

        bgm.Play();


        // ��ư ��Ȱ��ȭ
        startButton.interactable = false;
        GameObject st = GameObject.Find("Start");
        st.SetActive(false);
    }
}
