using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StartButton : MonoBehaviour, IPointerClickHandler
    , IPointerEnterHandler
    , IPointerExitHandler
{

    public Image nowImg;

    public Sprite[] spr;

    public AudioSource clickSFX;
    public AudioSource hoverSFX;

    // Start is called before the first frame update
    void Start()
    {
        nowImg = GetComponent<Image>();
        
        clickSFX = GameObject.FindWithTag("mainClickSfx").GetComponent<AudioSource>();
        hoverSFX = GameObject.FindWithTag("mainHoverSfx").GetComponent<AudioSource>();
    }

    public void PlayClickSound()
    {
        if (clickSFX != null)
            clickSFX.Play();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("HTP1", LoadSceneMode.Single);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
        hoverSFX.Play();
        nowImg.sprite = spr[1];
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        nowImg.sprite = spr[0];
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        PlayClickSound();

        SceneManager.LoadScene("HTP1", LoadSceneMode.Single);

    }
    
}
