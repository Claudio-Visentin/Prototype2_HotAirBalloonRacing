using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    public Controls P1;
    public Controls P2;
    public void OnUpP1Speed ()
    {
        P1.maxSpeed += 5;
    }
    public void OnUpP1Acceleration()
    {
        P1.acceleration += 10;
    }
    public void OnUpP1UpFloat()
    {
        P1.maxSpeedY += 5;
    }
    public void OnUpP2Speed()
    {
        P2.maxSpeed += 5;
    }
    public void OnUpP2Acceleration()
    {
        P2.acceleration += 10;
    }
    public void OnUpP2UpFloat()
    {
        P2.maxSpeedY += 5;
    }
}
