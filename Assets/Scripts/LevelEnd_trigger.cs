using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd_trigger : MonoBehaviour
{
  public GameManager GameManager;

  void OnTriggerEnter ()
  {
    GameManager.nextLevel();
  }

}
