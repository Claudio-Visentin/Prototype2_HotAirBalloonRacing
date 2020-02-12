using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float maxSpeed;
    public float acceleration;
    public float upFloat;
    public float mileage = 10;
    public Rigidbody2D rigid;
    public float health;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        print(rigid.velocity.magnitude);

        if (Input.GetKeyDown (KeyCode.W))
        {
            if (mileage > 0)
            {
                mileage -= 1;
                rigid.AddForce(new Vector2(0f, upFloat));
            }
        }

        if (Input.GetKey (KeyCode.D))
        {
            if (rigid.velocity.magnitude < maxSpeed)
            {
                rigid.AddForce(new Vector2(acceleration, 0f));
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (rigid.velocity.magnitude < maxSpeed)
            {
                rigid.AddForce(new Vector2(-acceleration, 0f));
            }
        }
    }
}
