using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    float delay = 0.7f;

    public GameObject completeLevelUI;


    public void nextLevel(){
        Debug.Log("nextLevel");
        completeLevelUI.SetActive(true);
    }

    public void EndGame(){
      if(gameHasEnded == false){
        gameHasEnded = true;
        Debug.Log("Game over");
        Invoke("end",delay);
      }
    }

    void end (){
      SceneManager.LoadScene(4);
    }

    public static void restart()
    {
      SceneManager.LoadScene(0);
    }

}
