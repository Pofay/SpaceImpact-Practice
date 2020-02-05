using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

class Score : MonoBehaviour, IOnHitEffect
{
    public int score = 100;
    // public Text scoreText;
    private ScoreTracker scoreTracker;

    void Start()
    {
        //scoreTracker = scoreText.GetComponent<ScoreTracker>();
        scoreTracker = GameObject.Find("Score").GetComponent<ScoreTracker>();
    }

    public void Apply()
    {
        if (!this.gameObject.activeSelf)
        {
            this.scoreTracker.UpdateScore(score);
        }
    }
}

