using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLose : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        GameManager.Instance.ShowLose();
    }
}