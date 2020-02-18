using UnityEngine;

public class Controls : MonoBehaviour
{
    public float maxSpeed;
    public float maxSpeedY;
    public float acceleration;
    public float upFloat;
    public Rigidbody2D rigid;
    public int health = 1000;
    public int modifier = 1;

    public bool player1;
    public bool player2;
    public bool cancontrol = false;
    public bool outofbounds = false;

    public Animator anim;
    bool startdone = false;

    public void RaceStart()
    {
        rigid.gravityScale = 1.4f;
        rigid.AddForce(new Vector2 (20000f, 0f));
        cancontrol = true;
        startdone = true;
    }

    void Update()
    {
        if (startdone == true)
        {
            if (outofbounds == true)
            {
                maxSpeedY = 0;
            }
            else
            {
                maxSpeedY = 15;
            }
        }
        if (cancontrol == true) { 
            if (rigid.velocity.y >= 1)
            {
                anim.SetBool("huff", true);
            } else
            {
                anim.SetBool("huff", false);
            }
        if (player1 == true) {
            if (Input.GetKey (KeyCode.W) && health >= 0)
             {
                    health -= 1;
                    if (rigid.velocity.y < maxSpeedY)
                    {
                        rigid.AddForce(new Vector2(0f, upFloat));
                    }
                    else if (rigid.velocity.x > maxSpeed)
                    {
                        float difference = rigid.velocity.y - maxSpeedY;
                        rigid.AddForce(new Vector2(0, -difference * modifier));
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
                rigid.AddForce (new Vector2 (-difference * modifier, 0));
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
                    rigid.AddForce(new Vector2(difference * modifier, 0));
                }
            }
        }
            if (player2 == true)
            {

                if (Input.GetKey(KeyCode.UpArrow) && health >= 0)
                {
                    health -= 1;
                    if (rigid.velocity.y < maxSpeedY)
                    {
                        rigid.AddForce(new Vector2(0f, upFloat));
                    }
                    else if (rigid.velocity.x > maxSpeed)
                    {
                        float difference = rigid.velocity.y - maxSpeedY;
                        rigid.AddForce(new Vector2(0, -difference * modifier));
                    }
                }

                if (Input.GetKey(KeyCode.RightArrow))
                {
                    if (rigid.velocity.x < maxSpeed)
                    {
                        rigid.AddForce(new Vector2(acceleration, 0f));
                    }
                    else if (rigid.velocity.x > maxSpeed)
                    {
                        float difference = rigid.velocity.x - maxSpeed;
                        rigid.AddForce(new Vector2(-difference * modifier, 0));
                    }
                }

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    if (rigid.velocity.x > -maxSpeed)
                    {
                        rigid.AddForce(new Vector2(-acceleration, 0f));
                    }
                    else if (rigid.velocity.x < -maxSpeed)
                    {
                        float difference = maxSpeed - rigid.velocity.x;
                        rigid.AddForce(new Vector2(difference * modifier, 0));
                    }
                }
            }
        }
    }
}
