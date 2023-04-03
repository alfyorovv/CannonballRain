using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScenes : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("main");
    }

    public void returnMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
        Pause.paused = false;
    }

}
