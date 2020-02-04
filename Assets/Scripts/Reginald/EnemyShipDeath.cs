using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

class EnemyShipDeath : MonoBehaviour, IShipDeath
{
    public Text scoreText;

    public int scoreOnDeath = 100;
    private ScoreTracker scoreTracker;

    void Start()
    {
        scoreTracker = scoreText.GetComponent<ScoreTracker>();
    }

    public void Apply()
    {
        Destroy(this.gameObject);
        scoreTracker.UpdateScore(scoreOnDeath);
    }
}
