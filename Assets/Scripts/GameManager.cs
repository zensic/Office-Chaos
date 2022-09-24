using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public int day = 1;
  public ValueMeter cowardSlider;
  public ValueMeter dangerSlider;

  void updateValues(int day, int cowardPts, int dangerPts)
  {
    day++;
    cowardSlider.SetMeter(cowardSlider.GetMeter() + cowardPts);
    cowardSlider.SetMeter(dangerSlider.GetMeter() + dangerPts);
  }

  static void updateScene(int day)
  {
    if (day == 5)
    {
      // Update the status values
    }
  }

  static void checkGameOver(int dangerValue)
  {
    if (dangerValue == 0)
    {
      // Game over scene
    }
  }
}
