using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    KeySelectController keyIndex;
    int nowIndex;
    GameObject slCont;

    void Start()
    {
        nowIndex = 0;
        keyIndex = GameObject.Find("KeySelectController").GetComponent<KeySelectController>();
        slCont = GameObject.Find("SliderController");
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            check(0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            check(1);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            check(2);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            check(3);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            check(4);
        }

        //???? ???? ??????
        void check(int i)
        {
            //???? ?????? ?? ?????? return 
            if (nowIndex >= 15)
            {
                if(i == 4)
                {
                    slCont.GetComponent<SliderController>().OnClickButtonS();
                    Correct.SoundPlay();
                }
                else
                {
                    //???? ???? ???? ???? ?? ?????? ????
                    TimerTwo timeBar = GameObject.Find("Timer").GetComponent<TimerTwo>();
                    timeBar.currentTime -= 5f; // 5?? ????
                    timeBar.UpdateTimeBar();   // ?????? ????????
                    return;
                }
            }
            else  //15?? ?? ?? ?????? ??
            {
                // key index?? i?? ????
                if (keyIndex.keyIndex[nowIndex] == i)
                {
                    Vector3 pos = keyIndex.keys[nowIndex].transform.position;
                    transform.position = pos;
                    keyIndex.keys[nowIndex].SetActive(false);
                    Correct.SoundPlay();

                    //15?? ?? ???????? ???? ????
                    if (nowIndex < 15)
                    {
                        nowIndex++;
                    }
                }
                else
                {
                    //???? ???? ???? ???? ?? ?????? ????
                    TimerTwo timeBar = GameObject.Find("Timer").GetComponent<TimerTwo>();
                    timeBar.currentTime -= 5f; // 5?? ????
                    timeBar.UpdateTimeBar();   // ?????? ????????
                    Wrong.SoundPlay();
                }
            }

            
            
        }
    }
}
