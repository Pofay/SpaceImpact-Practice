using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Standard_Enemy_Bullet") || collision.tag.Equals("Player_Bullet"))
        {
            Destroy(collision.gameObject);
        }
    }

}
