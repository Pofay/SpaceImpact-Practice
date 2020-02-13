using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAnimation : MonoBehaviour, IOnDeathEffect
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    public void Execute()
    {
        animator.SetBool("IsDestroyed", true);
        // Should be moved to a "Cleanup" death effect
        Invoke("DisableGameObject", 0.75f);
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
