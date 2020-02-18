using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    public Controls P1;
    public Controls P2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Player1"))
        {
            P1.outofbounds = false;
        }
        if (collision.CompareTag("Player2"))
        {
            P2.outofbounds = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            P1.outofbounds = true;
        }
        if (collision.CompareTag("Player2"))
        {
            P2.outofbounds = true;
        }
    }
}
