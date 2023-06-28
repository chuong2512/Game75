using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trung : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trung va cham");
        rigidbody2D.constraints = RigidbodyConstraints2D.None;
    }

    public void Bay()
    {
        rigidbody2D.constraints = RigidbodyConstraints2D.None;
    }
}
