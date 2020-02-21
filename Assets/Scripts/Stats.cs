using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public static int P1UpgradePoints;
    public static int P2UpgradePoints;

    public static int P1addSpeed;
    public static int P1addAcceleration;
    public static int P1addUpFloat;

    public static int P2addSpeed;
    public static int P2addAcceleration;
    public static int P2addUpFloat;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
