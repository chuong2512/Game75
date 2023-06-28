using System.Collections;
using System.Collections.Generic;
using JumpFrog;
using TMPro;
using UnityEngine;

public class TheLevelTMP : Singleton<TheLevelTMP>
{
    public TextMeshProUGUI textMeshProUgui;

    public int point;


    // Start is called before the first frame update
    void Start()
    {
        point = 0;
        textMeshProUgui.SetText($"0");
    }

    public float time = 1;
    
    void Update()
    {
        /*if (GameManager.Instance.currentState == State.Playing)
        {
            time -= Time.deltaTime;

            if (time <= 0)
            {
                Add();
                time = 1;
            }
        }*/
    }

    public void Add()
    {
        if (GameManager.Instance.currentState == State.Playing)
        {
            point++;
            textMeshProUgui.SetText($"{point}");
        }
    }
}