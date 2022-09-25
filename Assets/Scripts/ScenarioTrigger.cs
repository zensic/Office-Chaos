using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class ScenarioTrigger : MonoBehaviour
{
  public int scenarioIndex;
  public DialogueRunner dialogueRunner;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    switch (scenarioIndex)
    {
      case 1:
        // Init scenario
        dialogueRunner.StartDialogue("Scenario1.Start");
        //
        break;
      default:
        break;
    }
  }
}
