using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    Debug.Log("Deez nuts");
  }

  // Update is called once per frame
  void Update()
  {

  }

  void onTriggerEnter2D(Collision2D col)
  {
    Debug.Log(col);
  }
}
