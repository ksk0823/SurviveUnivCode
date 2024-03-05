using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalScoreUI : MonoBehaviour
{

    private ScoreManager scoreManager;
    private TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        scoreText = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    public void ViewFinalScore()
    {
        float fn = 0f;
        fn = (float)(scoreManager.Score / scoreManager.Num);
        scoreText.text = "Final Score\n" + fn.ToString("#.##");
    }
}
