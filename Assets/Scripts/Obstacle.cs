﻿using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag ("Player1"))
        {
            other.gameObject.GetComponent<Controls>().maxSpeed -= 15;
            other.gameObject.GetComponent<Controls>().modifier = 4;
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            other.gameObject.GetComponent<Controls>().maxSpeed -= 15;
            other.gameObject.GetComponent<Controls>().modifier = 4;
        }
    }

    private void OnTriggerExit2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            other.gameObject.GetComponent<Controls>().maxSpeed += 15;
            other.gameObject.GetComponent<Controls>().modifier = 2;
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            other.gameObject.GetComponent<Controls>().maxSpeed += 15;
            other.gameObject.GetComponent<Controls>().modifier = 2;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            other.gameObject.GetComponent<Controls>().health -= 25;
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            other.gameObject.GetComponent<Controls>().health -= 25;
        }
    }
}
