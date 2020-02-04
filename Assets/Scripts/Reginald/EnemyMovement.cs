using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float runSpeed = 3f;

    Rigidbody2D rigidbody; 

    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var currentVelocity = new Vector2(-1f, 0f);
        this.rigidbody.velocity = currentVelocity * runSpeed;
    }
}
