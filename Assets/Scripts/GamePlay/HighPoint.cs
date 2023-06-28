using System.Collections;
using System.Collections.Generic;
using JumpFrog;
using TMPro;
using UnityEngine;

public class HighPoint : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUgui;

    // Start is called before the first frame update
    void Start()
    {
        textMeshProUgui.SetText($"High Score : {DirGameDataManager.Ins.playerData.point}");
    }
}