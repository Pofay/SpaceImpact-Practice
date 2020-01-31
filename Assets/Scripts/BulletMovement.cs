using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float runSpeed = 5f;
    public float horizontalMove = 1f;

    Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        var velocity = new Vector2(horizontalMove, 0f);
        rigidBody.velocity = velocity * runSpeed;
    }
}
