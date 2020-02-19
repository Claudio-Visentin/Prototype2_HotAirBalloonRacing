using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour
{

    public Controls P1;
    public Controls P2;

    public TextMeshProUGUI P1Health;
    public TextMeshProUGUI P2Health;

    public Slider P1Slider;
    public Slider P2Slider;

    public TextMeshProUGUI introtext;

    public TextMeshProUGUI timer;
    public bool counttime = false;
    float timepassing;

    private void Awake()
    {
        StartCoroutine("LevelIntro");
    }

    IEnumerator LevelIntro ()
    {
        introtext.text = "3";
        yield return new WaitForSecondsRealtime(0.8f);
        introtext.text = "2";
        yield return new WaitForSecondsRealtime(0.8f);
        introtext.text = "1";
        yield return new WaitForSecondsRealtime(0.8f);
        introtext.gameObject.SetActive(false);
        P1.RaceStart();
        P2.RaceStart();
        counttime = true;
    }
    void Update()
    {
        P1Health.text = P1.health + "";
        P2Health.text = P2.health + "";
        P1Slider.value = P1.health;
        P2Slider.value = P2.health;
        if (counttime == true)
        {
            timepassing += Time.deltaTime;
            timer.text = "" + Mathf.Round(timepassing * 100)/ 100;
        }

    }
}
