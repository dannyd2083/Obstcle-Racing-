using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{

  public Text scoreText;

  void Start()
  {
    scoreText.text = "Final Score:" + Score.score.ToString();
  }

  public void Quit()
  {
    Application.Quit();
  }

  public void restart()
  {
    Debug.Log(Score.score.ToString());
    GameManager.restart();
  }


}
