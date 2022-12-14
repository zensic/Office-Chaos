using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class GameManager : MonoBehaviour
{
  // Drag and drop your Dialogue Runner into this variable.
  public DialogueRunner dialogueRunner;
  public PlayerMovement playerMovement;
  public GameObject ending1;
  public GameObject ending2;
  public GameObject ending3;

  public int day = 1;
  public ValueMeter cowardSlider;
  public ValueMeter dangerSlider;

  public void Awake()
  {
    dialogueRunner.AddCommandHandler<int, int>("updateValues", updateValues);
  }

  public void updateValues(int cowardPts, int dangerPts)
  {
    //updateScene();

    cowardSlider.SetMeter(cowardSlider.GetMeter() + cowardPts);
    dangerSlider.SetMeter(dangerSlider.GetMeter() + dangerPts);

    checkGameOver();

    // Update the day count
    day++;

    // Check for winnning the game
    if (day > 3)
    {
      ending3.SetActive(true);
    }
  }

  //public void updateScene()
  //{
  //  // End game
  //  if (day > 3)
  //  {
  //    ending3.SetActive(true);
  //  }
  //}

  public void checkGameOver()
  {
    if (dangerSlider.GetMeter() > 4)
    {
      // First game over scene
      ending1.SetActive(true);
    }
    else if (cowardSlider.GetMeter() > 4)
    {
      // Second game over scene
      ending2.SetActive(true);
    }
    else
    {
      playerMovement.canMove = true;
    }
  }
}
