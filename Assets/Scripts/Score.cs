using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
    //
    // }

    public Text scoreText;
    public static int score = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
