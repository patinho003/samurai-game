using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplayer : MonoBehaviour
{
    private float horizontalInput;

    public float speed;
    public float jumpForce;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate ()
    {
        horizontalInput = Input.GetAxis ("Horizontal");
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
