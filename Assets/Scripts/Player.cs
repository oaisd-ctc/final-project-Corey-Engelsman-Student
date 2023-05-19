using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    BoxCollider2D playerCollider;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        playerCollider = GetComponent<BoxCollider2D>();
    }

    void FixedUpdate()
    {
         rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
    
}
