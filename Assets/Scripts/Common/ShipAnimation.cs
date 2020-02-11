using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAnimation : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    public void ExecuteAnimation()
    {
        animator.SetBool("IsDestroyed", true);
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
