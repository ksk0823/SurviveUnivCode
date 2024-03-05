using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider sliderA;

    int gage;
    int gagefull;


    void Awake()
    {
        gage = 0;
        gagefull = 20;
    }

    void Update()
    {
        sliderA.value = (float)(gagefull-gage) / gagefull;
    }

    public void OnClickButtonS()
    {
        if(gage < gagefull)
        {
            gage += 1;
        }

        if(gage == gagefull)
        {
            TimerTwo timeBar = GameObject.Find("Timer").GetComponent<TimerTwo>();
            timeBar.GameOver();
        }
    }
}
