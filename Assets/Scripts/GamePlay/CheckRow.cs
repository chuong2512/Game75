using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRow : MonoBehaviour
{
    public float side;
    // Use this for initialization
    void Start ()
    {
        transform.position = new Vector3 (0, side * (Camera.main.orthographicSize * Camera.main.aspect + 0.5f), transform.position.z);
    }
}
