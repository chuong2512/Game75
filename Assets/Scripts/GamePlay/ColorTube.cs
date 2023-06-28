using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTube : MonoBehaviour
{
   public SpriteRenderer spriteRenderer;

   public void SetColor(Color color)
   {
      spriteRenderer.color = color;
   }
}
