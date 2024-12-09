using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public GameObject leftPositionObject, rightPositionObject;
    private float lefPosition, rightPosition;
    public float speed;
    

    private  void Start()
    {
        lefPosition = leftPositionObject.transform.position.x;
        rightPosition = rightPositionObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (transform.position.x < lefPosition)
        {
            transform.position = new Vector2 (lefPosition, transform.position.y);
            speed *= -1;
        }

        if (transform.position.x > rightPosition)
        {
            transform.position = new Vector2 (rightPosition, transform.position.y);
            speed*= -1;
        }
    }




}
