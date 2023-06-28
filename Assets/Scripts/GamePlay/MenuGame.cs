using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGame : MonoBehaviour
{
    public GameObject Sub;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void Play()
    {
        if (DirGameDataManager.Ins.playerData.time > 0)
        {
            SceneManager.LoadScene("Game");
        }
        else
        {
            Sub.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
    }

    
}
