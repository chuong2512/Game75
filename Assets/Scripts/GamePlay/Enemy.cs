using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<Trung>() != null)
        {
            col.gameObject.GetComponent<Trung>().Bay();
        }

        if (col.gameObject.GetComponent<PlayerController>() != null)
        {
            GameManager.Instance.ShowLose();
            Destroy(gameObject);
        }
    }
}