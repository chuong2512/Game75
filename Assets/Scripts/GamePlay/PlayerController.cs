using System.Collections;
using System.Collections.Generic;
using JumpFrog;
using Sirenix.OdinInspector;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    public Rigidbody2D Rigidbody2D;
    private bool play;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D.isKinematic = true;
    }

    public void Play()
    {
        Rigidbody2D.isKinematic = false;
        play = true;
    }

    public float speed = 2;

    public float high;


    void Update()
    {
        if (play && GameManager.Instance.currentState == State.Playing)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SpawnEgg(150);
            }
        }
    }

    [Button]
    private void SpawnEgg(int up)
    {
        Debug.Log("sdnfoinsoi");
        Rigidbody2D.velocity = Vector2.zero;
        Rigidbody2D.AddForce(Vector2.up * up);
    }
}