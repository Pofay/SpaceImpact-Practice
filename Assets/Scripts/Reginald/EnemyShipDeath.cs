using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class EnemyShipDeath : MonoBehaviour, IShipDeath
{
    public void Apply()
    {
        Destroy(this.gameObject);
    }
}
