using UnityEngine;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour
{
    public Text maxScoreText;
    private void Start()
    {
        maxScoreText.text = "MAX SCORE: " + PlayerPrefs.GetInt("Score").ToString();
    }
}
