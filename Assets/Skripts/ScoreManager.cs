using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text HighscoreText;
    public Text ScoreText;

    public static float score;
    float highscore;
        void Start()
    {
        score = 0;
    }

    void Update()
    {
        ScoreText.text = $"Score: {score}";
        if (score >= highscore)
        {
            highscore = score;
            HighscoreText.text = $"Hight Score: {highscore}";
        }
    }
}
