using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startingSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Boolean isRight = UnityEngine.Random.value >= 0.5;

        float xVelocity = -1f;

        if (isRight == true) ;
        {
            xVelocity = 1f;
        }

        float yVelocity = UnityEngine.Random.Range(-1, 1);
    
    rb.velocity = new Vector2(xVelocity * startingSpeed, yVelocity * startingSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
