using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
public class MainMenuAndUpgrades : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject UpgradeMenu;
    public GameObject PlayMenu;

    public TextMeshProUGUI upgradepointsP1;
    public TextMeshProUGUI upgradepointsP2;

    public void Update()
    {
        upgradepointsP1.text = "Upgrade Points: " + Stats.P1UpgradePoints;
        upgradepointsP2.text = "Upgrade Points: " + Stats.P2UpgradePoints;
    }
    public void OnPlay ()
    {
        MainMenu.SetActive(false);
        PlayMenu.SetActive(true);
    }
    public void ClosePlay ()
    {
        PlayMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void OnQuit ()
    {
        Application.Quit();
    }
    public void DayLevel ()
    {
        SceneManager.LoadScene("DayLevel");
    }
    public void NightLevel ()
    {
        SceneManager.LoadScene("NightLevel");
    }

    public void OpenUpgrades ()
    {
        MainMenu.SetActive(false);
        UpgradeMenu.SetActive(true);
    }
    public void CloseUpgrades ()
    {
        UpgradeMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void OnUpP1Speed ()
    {
        if (Stats.P1UpgradePoints >= 1)
        {
            Stats.P1addSpeed += 5;
            Stats.P1UpgradePoints -= 1;
        }
    }
    public void OnUpP1Acceleration()
    {
        if (Stats.P1UpgradePoints >= 1)
        {
            Stats.P1addAcceleration += 100;
            Stats.P1UpgradePoints -= 1;
        }
    }
    public void OnUpP1UpFloat()
    {
        if (Stats.P1UpgradePoints >= 1)
        {
            Stats.P1addUpFloat += 5;
            Stats.P1UpgradePoints -= 1;
        }
    }
    public void OnUpP2Speed()
    {
        if (Stats.P2UpgradePoints >= 1)
        {
            Stats.P2addSpeed += 5;
            Stats.P2UpgradePoints -= 1;
        }
    }
    public void OnUpP2Acceleration()
    {
        if (Stats.P2UpgradePoints >= 1)
        {
            Stats.P2addAcceleration += 100;
            Stats.P2UpgradePoints -= 1;
        }
    }
    public void OnUpP2UpFloat()
    {
        if (Stats.P2UpgradePoints >= 1)
        {
            Stats.P2addUpFloat += 5;
            Stats.P2UpgradePoints -= 1;
        }
    }
}
