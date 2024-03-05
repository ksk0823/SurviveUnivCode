using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class QuitButton : MonoBehaviour, IPointerClickHandler
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
        Debug.Log("Quit");
        clickSFX.Play();
        Application.Quit();
    }
}
