using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuAndUpgrades : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject UpgradeMenu;

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
        MainMenu.SetActive(true);
        UpgradeMenu.SetActive(false);
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
