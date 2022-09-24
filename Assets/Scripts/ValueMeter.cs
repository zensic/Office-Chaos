using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueMeter : MonoBehaviour
{
  public Slider slider;

  public void SetMeter (int meter)
  {
    slider.value = meter;
  }

  public void SetMaxMeter (int meter)
  {
    slider.maxValue = meter;
    slider.value = meter;
  }
}
