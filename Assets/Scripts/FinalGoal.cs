using UnityEngine;
using TMPro;
public class FinalGoal: MonoBehaviour
{
    public TextMeshProUGUI winnertext;

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag ("Player1"))
        {
            winnertext.gameObject.SetActive(true);
            winnertext.text = "Player 1 Wins!";
            Destroy(this);
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            winnertext.gameObject.SetActive(true);
            winnertext.text = "Player 2 Wins!";
            Destroy(this);
        }
    }
}
