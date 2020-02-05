using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = string.Format("Score: {0}", score.ToString());
    }

    public void UpdateScore(int value)
    {
        score += value;
    }
}
