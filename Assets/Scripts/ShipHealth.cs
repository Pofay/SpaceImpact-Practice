using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : MonoBehaviour
{
    public float health = 3;
    public string bulletTag = "Standard_Enemy_Bullet";
    public IShipDeath shipDeath; // Should be on Hit Effect

    void Start()
    {
        shipDeath = GetComponent<IShipDeath>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(bulletTag))
        {
            // Health needs to be pulled up for lives.
            health -= 1;
            if (health == 0)
            {
                this.shipDeath.Apply();
            }
            Destroy(collision.gameObject);
        }
    }
}
