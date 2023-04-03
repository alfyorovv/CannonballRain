using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;

    private void Awake()
    {
        score = 0;
    }

  
    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
