using UnityEngine;
using UnityEngine.UI;

public class SoundControl : MonoBehaviour
{
    public bool soundEnabled;
    public Sprite sprite1, sprite2;
    public Image image;


    public void Awake()
    {
        if (AudioListener.volume == 1)
            soundEnabled = true;
        else
            soundEnabled = false;

        if (soundEnabled)
            image.sprite = sprite1;
        else
            image.sprite = sprite2;
    }
    public void switchSound()
    {
        if (soundEnabled)
        {
            AudioListener.volume = 0;
            soundEnabled = !soundEnabled;
            image.sprite = sprite2;
        }
        else
        {
            AudioListener.volume = 1f;
            soundEnabled = !soundEnabled;
            image.sprite = sprite1;
        }
    }


}
