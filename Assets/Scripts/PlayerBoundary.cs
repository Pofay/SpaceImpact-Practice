using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundary : MonoBehaviour
{
    private Vector2 playerBoundary;
    // Start is called before the first frame update
    void Start()
    {
        playerBoundary = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        var viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, playerBoundary.x, playerBoundary.x * -1);
        viewPos.y = Mathf.Clamp(viewPos.y, playerBoundary.y, playerBoundary.y * -1);
        var body = GetComponent<Rigidbody2D>();
        body.position = viewPos;
    }
}
