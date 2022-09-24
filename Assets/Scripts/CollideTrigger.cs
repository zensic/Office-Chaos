using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideTrigger : MonoBehaviour
{
  void onTriggerEnter(Collision col)
  {
    Debug.Log(col);
  }

  // Start is called before the first frame update
  void Start()
  {
    Debug.Log("Deez nuts");
  }

  // Update is called once per frame
  void Update()
  {

  }
}
