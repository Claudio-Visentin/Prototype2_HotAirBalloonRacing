using UnityEngine;

public class Controls : MonoBehaviour
{
    public float maxSpeed;
    public float acceleration;
    public float upFloat;
    public float mileage = 10;
    public Rigidbody2D rigid;
    public int health;

    void Start()
    {
        
    }

    void FixedUpdate()
    {

        print(rigid.velocity.x);

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
            if (rigid.velocity.x < maxSpeed)
            {
              rigid.AddForce(new Vector2(acceleration, 0f));
            } 
            else if (rigid.velocity.x > maxSpeed)
            {
                float difference = rigid.velocity.x - maxSpeed;
                rigid.AddForce (new Vector2 (-difference, 0));
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (rigid.velocity.x > -maxSpeed)
            {
                rigid.AddForce(new Vector2(-acceleration, 0f));
            }
            else if (rigid.velocity.x < -maxSpeed)
            {
                float difference = maxSpeed - rigid.velocity.x;
                rigid.AddForce(new Vector2(difference, 0));
            }
        }
    }
}
