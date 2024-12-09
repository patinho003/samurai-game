using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private Rigidbody2D rigidBody;
    private Animator playeranim;
    private SpriteRenderer spriteRenderer;
    private Vector2 move;
    float horizontalInput;
    public int life = 5;
    private bool jump;
    private bool isGrounded;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        playeranim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
         horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        } 
        move = new Vector2(horizontalInput, transform.position.y);
    }

    void FixedUpdate()
    {
          Move();
        if (isGrounded && jump)
        {
            Jump();
        }
        jump = false;  


    }

        void Jump()
    {

        rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce * Time.fixedDeltaTime);
    }

    void Move()
    {

        rigidBody.velocity = new Vector2(move.x * speed * Time.fixedDeltaTime, rigidBody.velocity.y);

    }
     
    void Flip ()
    {
        rigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), rigidBody.velocity.y);


            if(rigidBody.velocity.x < 0f)
            {
                spriteRenderer.flipX = true;
            }
            else if (rigidBody.velocity.x > 0f)
                spriteRenderer.flipX = false;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        
    }
}
