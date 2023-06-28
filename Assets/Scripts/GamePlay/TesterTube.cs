using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TesterTube : MonoBehaviour
{
    public List<Color> colors = new List<Color>();
    public ColorTube[] colour;

    public GameObject ChooseObj;

    public void Choose()
    {
        ChooseObj.SetActive(true);
    }
    public void Painting()
    {
        for (int i = 0; i < colour.Length; i++)
        {
            if (i < colors.Count)
            {
                colour[i].SetColor(colors[i]);
            }
            else
            {
                colour[i].SetColor(Color.white);
            }
        }
    }

    public void UnChoose()
    {
        ChooseObj.SetActive(false);
    }

    public void SetEmpColor()
    {
        for (int i = 0; i < colour.Length; i++)
        {
            colour[i].SetColor(Color.white);
        }

        colors = new List<Color>();
    }

    public void AddColor(Color color)
    {
        colors.Add(color);
        Painting();
    }
    public void SetFullColor(Color color)
    {
        colors = new List<Color>();

        for (int i = 0; i < colour.Length; i++)
        {
            colour[i].SetColor(color);
            colors.Add(color);
        }
    }

    

    public void RemoveColour()
    {
        colors.RemoveAt(colors.Count - 1);
        Painting();
    }

    

    public void MoveToTube(TesterTube moveTube, bool checkColor = false)
    {
        if (moveTube.colors.Count >= 4)
        {
            return;
        }

        if (colors != null && colors.Count > 0)
        {
            var last = colors[^1];

            if (moveTube.colors != null && moveTube.colors.Count > 0)
            {
                if (checkColor)
                {
                    if (last != moveTube.colors[^1])
                    {
                        return;
                    }
                }
            }

            RemoveColour();
            moveTube.AddColor(last);


            MoveToTube(moveTube, true);
        }
    }

    

    public bool CheckTrueTube()
    {
        return colors.Count == 0
               || (colors.Count == 4 && colors[0] == colors[1] && colors[1] == colors[2] && colors[2] == colors[3]);
    }
    
    public void MoveToTubeRan(TesterTube moveTube)
    {
        if (moveTube.colors.Count >= 4)
        {
            return;
        }

        if (colors != null && colors.Count > 0)
        {
            var last = colors[^1];

            RemoveColour();
            moveTube.AddColor(last);
        }
    }
}