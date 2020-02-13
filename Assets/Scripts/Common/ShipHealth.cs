using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ShipHealth : MonoBehaviour, IOnHitEffect
{
    public int health = 3;
    private IOnDeathEffect[] deathEffects;

    public void Start()
    {
        deathEffects = GetComponents<IOnDeathEffect>();
    }

    public void Apply()
    {
        health -= 1;
        if (health == 0)
        {
            foreach (var e in deathEffects)
            {
                e.Execute();
            }
        }
    }
}

