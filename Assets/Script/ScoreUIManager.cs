using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIManager : MonoBehaviour
{
   public static float highscore;



    TextMeshProUGUI scoreFinal;
    TextMeshProUGUI HighScoreFinal;
    TextMeshProUGUI HighScoreNew;
    // Start is called before the first frame update
    void Start()
    {
        highscore = 0;
        scoreFinal = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        HighScoreNew = transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        HighScoreFinal = transform.GetChild(3).GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        if (UIManager.score > highscore)

        {
            highscore = UIManager.score;
        }
        //letting player know they got a new highscore
       string newScore = (UIManager.score > highscore) ? "NEW HIGHSCORE" : "HIGHSCORE";
       HighScoreNew.text = newScore;

        scoreFinal.text = Mathf.RoundToInt(UIManager.score).ToString("0000");
        HighScoreFinal.text = Mathf.RoundToInt(highscore).ToString("0000");

      
    }
}
