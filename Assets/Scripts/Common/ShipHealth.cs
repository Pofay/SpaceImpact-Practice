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
    private ShipAnimation animation;

    public void Start()
    {
        animation = GetComponent<ShipAnimation>();
    }

    public void Apply()
    {
        health -= 1;
        if (health == 0)
        {
            animation.ExecuteAnimation();
        }
    }
}

