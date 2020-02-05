using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthIndicator : MonoBehaviour
{
    public Text healthText;
    public GameObject player;
    private ShipHealth playerHealth;

    void Start()
    {
        if (player == null)
        {
            player = GameObject.Find("Player");
        }
        playerHealth = player.GetComponent<ShipHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = string.Format("Health: {0}", playerHealth.health);
    }
}
