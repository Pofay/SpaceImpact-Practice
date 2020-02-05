using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverListener : MonoBehaviour
{
    public ShipHealth playerHealth;
    public GameObject gameOverMenu;

    public void Start()
    {
        playerHealth = GameObject.Find("Player").GetComponent<ShipHealth>();
        gameOverMenu.SetActive(false);
    }

    public void Update()
    {
        if(playerHealth.health == 0)
        {
            gameOverMenu.SetActive(true);
            var enemies = GameObject.FindGameObjectsWithTag("Standard_Enemy");
            foreach (var enemy in enemies)
            {
                enemy.SetActive(false);
            }
        }
    }


}
