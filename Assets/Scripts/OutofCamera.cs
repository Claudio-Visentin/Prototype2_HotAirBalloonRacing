using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofCamera : MonoBehaviour
{
    public Renderer P1;
    public Renderer P2;
    public Transform spanwer;
    public void Update()
    {
        if (P1.isVisible == false)
        {
            P1.gameObject.transform.position = spanwer.position;
        }
        if (P2.isVisible == false)
        {
            P2.gameObject.transform.position = spanwer.position;
        }
    }
}
