using UnityEngine;
using TMPro;
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
            
            winnertext.gameObject.SetActive(true);
            winnertext.text = "Player 1 Wins!";
            P1.cancontrol = false;
            P2.cancontrol = false;
            timer.counttime = false;
            Destroy(this);
        }
        if (other.gameObject.CompareTag("Player2"))
        {
            winnertext.gameObject.SetActive(true);
            winnertext.text = "Player 2 Wins!";
            P1.cancontrol = false;
            P2.cancontrol = false;
            timer.counttime = false;
            Destroy(this);
        }
    }
}
