using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;
public class FinalGoal: MonoBehaviour
{
    public TextMeshProUGUI winnertext;
    public Controls P1;
    public Controls P2;
    public UI timer;

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag ("Player1"))
        {
            Stats.P1UpgradePoints += 1;
            winnertext.gameObject.SetActive(true);
            winnertext.text = "Player 1 Wins!";
            P1.cancontrol = false;
            P2.cancontrol = false;
            timer.counttime = false;
            Destroy(gameObject.GetComponent <BoxCollider2D> ());          
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            Stats.P2UpgradePoints += 1;
            winnertext.gameObject.SetActive(true);
            winnertext.text = "Player 2 Wins!";
            P1.cancontrol = false;
            P2.cancontrol = false;
            timer.counttime = false;
            Destroy(gameObject.GetComponent<BoxCollider2D>());
        }
        StartCoroutine("GoToMenu");
    }

    IEnumerator GoToMenu ()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("MainMenu");

    }
}
