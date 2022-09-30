using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class GameManager : MonoBehaviour
{
  // Drag and drop your Dialogue Runner into this variable.
  public DialogueRunner dialogueRunner;

  public int day = 1;
  public ValueMeter cowardSlider;
  public ValueMeter dangerSlider;

  public void Awake()
  {
    dialogueRunner.AddCommandHandler<int, int>(
        "updateValues",
        updateValues
    );
  }

  public void updateValues(int cowardPts, int dangerPts)
  {
    day++;
    cowardSlider.SetMeter(cowardSlider.GetMeter() + cowardPts);
    dangerSlider.SetMeter(dangerSlider.GetMeter() + dangerPts);
  }

  public void updateScene()
  {
    if (day == 5)
    {
      // Show screen transition

      // Update number of days in text
    }
  }

  public void checkGameOver()
  {
    if (dangerSlider.GetMeter() > 4)
    {
      // First game over scene

    }
    else if (cowardSlider.GetMeter() > 4)
    {
      // Second game over scene

    }
  }
}
