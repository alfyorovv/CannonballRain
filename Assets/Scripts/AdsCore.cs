using UnityEngine;
using UnityEngine.Advertisements;

public class AdsCore : MonoBehaviour
{

    private string gameId = "4187047";

    public string video = "Interstitial_Android";

    private void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize(gameId, false);
        }
    }

    public static void ShowAdsVideo(string placementId)
    {
        if(Advertisement.IsReady())
        {
            Advertisement.Show(placementId);
        }
        else
        {
            Debug.Log("Advertisement not ready!");
        }
    }

}
