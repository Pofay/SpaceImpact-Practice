using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 12f;

    Rigidbody2D rigidBody;
    float horizontalMove = 0f;
    float verticalMove = 0f;

    void Start()
    {
        this.rigidBody = GetComponentInChildren<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical"); 
    }

    void FixedUpdate()
    {
        var currentVelocity = new Vector2(horizontalMove, verticalMove);
        rigidBody.velocity = currentVelocity * runSpeed;
    }
}
