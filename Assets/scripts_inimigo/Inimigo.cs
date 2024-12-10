using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public GameObject leftPositionObject, rightPositionObject;
    private float lefPosition, rightPosition;
    public float speed;
    private bool isGrounded;
    private Rigidbody2D rigidBody;
    private int move;
    

    private  void Start()
    {   
        move = 1;
        rigidBody = GetComponent<Rigidbody2D>();
        lefPosition = leftPositionObject.transform.position.x;
        rightPosition = rightPositionObject.transform.position.x;
    }

    void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(move * speed , rigidBody.velocity.y);

        if (rigidBody.position.x < lefPosition)
        {
            rigidBody.position = new Vector2 (lefPosition, rigidBody.position.y);
            move = 1;
        }

        if (rigidBody.position.x > rightPosition)
        {
            rigidBody.position = new Vector2 (rightPosition, rigidBody.position.y);
            move = -1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }




}
