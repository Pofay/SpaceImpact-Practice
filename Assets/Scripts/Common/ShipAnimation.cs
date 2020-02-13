using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAnimation : MonoBehaviour
{
    private Animator animator;
    private AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        this.audioManager = FindObjectOfType<AudioManager>();
    }

    public void ExecuteAnimation()
    {
        animator.SetBool("IsDestroyed", true);
        Invoke("DisableGameObject", 0.75f);
        audioManager.Play("ShipDeath");
        var collision = this.GetComponent<ShipCollision>();
        Destroy(collision);
    }

    public void DisableGameObject()
    {
        this.gameObject.SetActive(false);
    }

    public void OnDisable()
    {
        CancelInvoke("DisableGameObject");
    }

}
