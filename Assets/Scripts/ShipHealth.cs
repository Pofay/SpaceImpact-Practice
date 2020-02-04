using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

class ShipHealth : MonoBehaviour, IOnHitEffect
{
    public int health = 3;

    public void Apply()
    {
        health -= 1;
        if (health == 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}

