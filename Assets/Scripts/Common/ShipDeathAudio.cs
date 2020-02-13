using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class ShipDeathAudio : MonoBehaviour, IOnDeathEffect
{
    private AudioManager audioManager;

    void Start()
    {
        this.audioManager = FindObjectOfType<AudioManager>();
    }
    public void Execute()
    {
        audioManager.Play("ShipDeath");
    }
}
