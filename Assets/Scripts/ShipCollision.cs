using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCollision : MonoBehaviour
{
    public string bulletTag = "Standard_Enemy_Bullet";
    public IOnHitEffect[] shipOnHitEffects; 

    void Start()
    {
        shipOnHitEffects = GetComponents<IOnHitEffect>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(bulletTag))
        {
            foreach (var effect in shipOnHitEffects)
            {
                effect.Apply();
            }
            Destroy(collision.gameObject);
        }
    }
}
