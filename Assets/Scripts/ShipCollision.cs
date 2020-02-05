using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCollision : MonoBehaviour
{
    public string bulletTag = "Standard_Enemy_Bullet";
    public IOnHitEffect[] onHitEffects; 

    void Start()
    {
        onHitEffects = GetComponents<IOnHitEffect>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(bulletTag))
        {
            foreach (var effect in onHitEffects)
            {
                effect.Apply();
            }
            Destroy(collision.gameObject);
        }
    }
}
