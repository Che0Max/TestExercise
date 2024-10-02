using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static float score;
    public int record;

    public Text ScoreText;
    public Text RecordText;//Рекорд

    
    
    // Start is called before the first frame update
    void Start()
    {
        record = (int)ScoreManager.score;
        ScoreText.text = $"score: {record}";
        

        if (PlayerPrefs.GetInt("score") < record)
        {
            PlayerPrefs.SetInt("score", record);
        }
        RecordText.text = $"Record: { PlayerPrefs.GetInt("score")}";
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
