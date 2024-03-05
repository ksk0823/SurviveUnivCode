using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSfxBest : MonoBehaviour
{
    static ClickSfxBest Instance;

    void Awake()
    {
        // var objs = FindObjectsOfType<DontDestroyObject>();
        if (Instance != this && Instance != null)
        {
            Destroy(transform.gameObject);
            return;
        }
        else
        {

            Instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }

    }
}
