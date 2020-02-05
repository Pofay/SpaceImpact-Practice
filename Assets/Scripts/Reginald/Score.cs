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

    private ScoreTracker scoreTracker;

    void Start()
    {
        scoreTracker = GameObject.Find("ScoreIndicator").GetComponent<ScoreTracker>();
    }

    public void Apply()
    {
        if (!this.gameObject.activeSelf)
        {
            this.scoreTracker.UpdateScore(score);
        }
    }
}

