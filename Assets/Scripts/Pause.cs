using UnityEngine;

public class Pause : MonoBehaviour
{

    public static bool paused = false;
    public GameObject panel;
    public GameObject button;
    public GameObject bgBlur;

    public void pauseGame()
    {
            Time.timeScale = 0;
            paused = true;
            panel.SetActive(true);
            button.SetActive(false);
            bgBlur.SetActive(true);
    }

    public void resumeGame()
    {
        Time.timeScale = 1;
        paused = false;
        panel.SetActive(false);
        button.SetActive(true);
        bgBlur.SetActive(false);
    }
}
