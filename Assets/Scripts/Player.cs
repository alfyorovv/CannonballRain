using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject restart;
    public GameObject menu;
    public GameObject pause;
    public GameObject bgBlur;
    public static bool lose = false;
    public static int numberOfLoses = 0;

    private void Awake()
    {
        lose = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            lose = true;
            restart.SetActive(true);
            menu.SetActive(true);
            pause.SetActive(false);
            bgBlur.SetActive(true);

            numberOfLoses++;
            if(numberOfLoses == 3)
            {
                AdsCore.ShowAdsVideo("Interstitial_Android");
                numberOfLoses = 0;
            }

            if (PlayerPrefs.GetInt("Score")<Score.score)
                PlayerPrefs.SetInt("Score", Score.score);
        }
        
    }
}
