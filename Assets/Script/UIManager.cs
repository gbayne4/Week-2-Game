using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    TextMeshProUGUI scoreCounter;
    float timer;
    public static float score;

    // Start is called before the first frame update
    void Start()
    {

        scoreCounter = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        timer = 0;

    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        score = timer;
        // PlayerPrefs.SetFloat("Score", timer);
        // PlayerPrefs.Save();

        scoreCounter.text = Mathf.RoundToInt(timer).ToString("0000");

    }
}
