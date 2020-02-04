using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class PlayerShipDeath : MonoBehaviour, IShipDeath
{
    public void Apply()
    {
        Destroy(this.gameObject);
        // GameOver...
    }
}
