using System;
using System.Collections;
using System.Collections.Generic;
using JumpFrog;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum State
{
    Start,
    Playing,
    Lose,
}

public class GameManager : Singleton<GameManager>
{
    public State currentState = State.Start;

    public GameObject loseObj;

    public TextMeshProUGUI point, highPoint;

    public GameObject tap;

    public GameObject[] respawns;

    public void SetState(State state)
    {
        currentState = state;
    }

    public void Restart(bool up)
    {
        if (up)
        {
            DirGameDataManager.Ins.playerData.LevelUP();
        }

        SceneManager.LoadScene("Game");
    }

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentState != State.Playing)
        {
            SetState(State.Playing);
            tap.SetActive(false);
            PlayerController.Instance.Play();
        }
    }

    private bool CheckWin()
    {
        return true;
    }

    public void MoveColor(TesterTube tube)
    {
    }


    public void Help()
    {
    }

    public void ShowLose()
    {
        Time.timeScale = 0;

        loseObj.SetActive(true);

        SetState(State.Lose);

        point.SetText($"Your Point : {TheLevelTMP.Instance.point}");

        DirGameDataManager.Ins.playerData.SetPoint(TheLevelTMP.Instance.point);

        highPoint.SetText($"Best Point : {DirGameDataManager.Ins.playerData.point}");
    }

    public void ReStart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }

    public void Home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void Continue()
    {
        if (DirGameDataManager.Ins.playerData.intHelp >= 10)
        {
            Time.timeScale = 1;
            DirGameDataManager.Ins.playerData.SubHelp(10);
            loseObj.SetActive(false);

            respawns = GameObject.FindGameObjectsWithTag("Enemy");

            if (respawns != null)
            {
                foreach (GameObject respawn in respawns)
                {
                    Destroy(respawn);
                }
            }

            SetState(State.Playing);
        }
    }
}