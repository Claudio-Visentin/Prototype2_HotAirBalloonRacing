using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool healthChange;
    public int healthDifference;
    public bool speedChange;
    GameObject PlayerCaught;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Player1"))
        {
            PlayerCaught = GameObject.FindGameObjectWithTag("Player1");
            if (healthChange == true)
            {
                PlayerCaught.GetComponent<Controls>().health += healthDifference;
            }
            if (speedChange == true)
            {
                StartCoroutine("SpeedChange");
            }

        }

        if (other.gameObject.CompareTag("Player2"))
        {
            PlayerCaught = GameObject.FindGameObjectWithTag("Player2");
        }
    }
}
