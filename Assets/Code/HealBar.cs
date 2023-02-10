using System;
using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;
using UnityEngine.UIElements;
using Image = Microsoft.Unity.VisualStudio.Editor.Image;
using Slider = UnityEngine.UI.Slider;

public class HealBar : MonoBehaviour
{
    public Slider _Slider;
    public Gradient _Gradient;
    public UnityEngine.UI.Image fill;

   public void SetHeat(int Heatl)
   {
      _Slider.value = Heatl;
      fill.color = _Gradient.Evaluate(_Slider.normalizedValue);


   }
   public void SetMax(int Heatl)
   {
       _Slider.maxValue = Heatl;
       _Slider.value = Heatl;
      fill.color = _Gradient.Evaluate(1f);
      //test

   }

  
}
