using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private float score = 0f;
    private int num = 0;

    public float Score
    {
        get { return score; }
        set { score = value; }
    }

    public int Num
    {
        get { return num; }
        set { num = value; }
    }
}
