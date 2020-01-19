using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float runSpeed = 5f;

    float verticalMove = 1f;
    Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        var velocity = new Vector2(0f, verticalMove);
        rigidBody.velocity = velocity * runSpeed;
    }
}
