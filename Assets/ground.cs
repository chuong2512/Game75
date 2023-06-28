using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D.velocity = Vector2.left * speed;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<PlayerController>() != null)
        {
            TheLevelTMP.Instance.Add();
        }
    }
}