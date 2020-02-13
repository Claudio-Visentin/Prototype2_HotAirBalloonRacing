using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public bool healthChange;
    public int healthDifference;
    public bool speedChange;
    public int speedChangeAmount;
    GameObject PlayerCaught;

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag ("Player1"))
        {
            PlayerCaught = GameObject.FindGameObjectWithTag("Player1");
            if (healthChange == true)
            {
                PlayerCaught.GetComponent<Controls>().health += healthDifference;
                Destroy(this);
            }
            if (speedChange == true)
            {
                StartCoroutine("SpeedChange");
            }

        }

        if (other.gameObject.CompareTag("Player2"))
        {
            PlayerCaught = GameObject.FindGameObjectWithTag("Player2");
            if (healthChange == true)
            {
                PlayerCaught.GetComponent<Controls>().health += healthDifference;
                Destroy(this);
            }
            if (speedChange == true)
            {
                StartCoroutine("SpeedChange");
            }
        }
    }

    IEnumerator SpeedChange ()
    {
        gameObject.GetComponent<Image>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        PlayerCaught.GetComponent<Controls>().maxSpeed += speedChangeAmount;
        yield return new WaitForSeconds(2f);
        PlayerCaught.GetComponent<Controls>().maxSpeed = 10;
        Destroy(this);
    }
}
