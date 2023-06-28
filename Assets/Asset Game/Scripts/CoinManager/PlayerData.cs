using System;
using UnityEngine;

public class Constant
{
    public static string DataKey_PlayerData = "player_data";
    public static int countSong = 3;
    public static int priceUnlockSkin = 100;
}

public class PlayerData : BaseData
{
    public int intHelp;
    public int intLevel;
    public int currentSkin;
    public bool[] listSkins;

    public long time;
    public string timeRegister;

    public void SetTimeRegister(long timeSet)
    {
        timeRegister = DateTime.Now.ToBinary().ToString();
        time = timeSet;
        Save();
    }

    public void ResetTime()
    {
        time = 0;
        Save();
    }


    public Action<int> onChangeDiamond;
    public int point;

    public override void Init()
    {
        prefString = Constant.DataKey_PlayerData;
        if (PlayerPrefs.GetString(prefString).Equals(""))
        {
            ResetData();
        }

        base.Init();
    }

    public void Unlock(int id)
    {
        if (!listSkins[id])
        {
            listSkins[id] = true;
        }

        Save();
    }


    public void SetPoint(int pointt)
    {
        if (pointt >= point)
        {
            point = pointt;
        }

        Save();
    }

    public void LevelUP()
    {
        intLevel++;
        Save();
    }

    public bool CheckLock(int id)
    {
        return this.listSkins[id];
    }

    public void ChooseSong(int i)
    {
        currentSkin = i;
        Save();
    }


    public void AddHelp(int a)
    {
        intHelp += a;

        onChangeDiamond?.Invoke(intHelp);

        Save();
    }

    public bool CheckCanUnlockChange()
    {
        return intHelp >= Constant.priceUnlockSkin;
    }

    public void SubHelp(int a)
    {
        intHelp -= a;

        if (intHelp < 0)
        {
            intHelp = 0;
        }

        onChangeDiamond?.Invoke(intHelp);

        Save();
    }

    public override void ResetData()
    {
        timeRegister = DateTime.Now.ToBinary().ToString();
        time = 7 * 24 * 60 * 60;
        point = 0;
        intHelp = 0;
        intLevel = 0;
        currentSkin = 0;
        listSkins = new bool[Constant.countSong];

        for (int i = 0; i < 1; i++)
        {
            listSkins[i] = true;
        }

        Save();
    }

    protected override void CheckAppendData()
    {
        int check = PlayerPrefs.GetInt("FirstDemo", 0);

        if (check == 0)
        {
            timeRegister = DateTime.Now.ToBinary().ToString();
            time = 7 * 24 * 60 * 60;
            PlayerPrefs.SetInt("FirstDemo", 1);
        }
    }
}