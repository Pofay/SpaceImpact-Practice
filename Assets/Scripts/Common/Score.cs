using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Score : MonoBehaviour, IOnDeathEffect
{
    public int amount = 100;
    private ScoreIndicator scoreTracker;

    void Start()
    {
        this.scoreTracker = GameObject.Find("ScoreIndicator").GetComponent<ScoreIndicator>();
    }

    public void Execute()
    {
        scoreTracker.UpdateScore(amount);
    }

}

