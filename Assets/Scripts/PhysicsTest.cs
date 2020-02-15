using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    public Rigidbody2D rigid;

    private void Start()
    {
        rigid.AddForce (new Vector2 (400f, 0f));
    }
}
