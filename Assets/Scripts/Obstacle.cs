using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag ("Player1"))
        {
            other.gameObject.GetComponent<Controls>().maxSpeed -= 5;
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            other.gameObject.GetComponent<Controls>().maxSpeed -= 5;
        }
    }

    private void OnTriggerExit2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            other.gameObject.GetComponent<Controls>().maxSpeed += 5;
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            other.gameObject.GetComponent<Controls>().maxSpeed += 5;
        }
    }
}
