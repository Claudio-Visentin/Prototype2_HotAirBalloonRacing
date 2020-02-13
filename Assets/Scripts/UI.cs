using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    public Controls P1;
    public Controls P2;

    public TextMeshProUGUI P1Health;
    public TextMeshProUGUI P2Health;

    public Slider P1Slider;
    public Slider P2Slider;

    void Update()
    {
        P1Health.text = P1.health + "";
       // P2Health.text = P2.health + "";
        P1Slider.value = P1.health;
       // P2Slider.value = P2.health;
    }
}
