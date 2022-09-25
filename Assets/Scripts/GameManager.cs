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
    cowardSlider.SetMeter(dangerSlider.GetMeter() + dangerPts);
  }

  public void updateScene()
  {
    if (day == 5)
    {
      // Update the status values

    }
  }

  public void checkGameOver()
  {
    if (dangerSlider.GetMeter() == 0)
    {
      // Game over scene

    }
  }
}
