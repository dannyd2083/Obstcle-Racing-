using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Level : MonoBehaviour
{
  public void loadNextLevel()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
}
