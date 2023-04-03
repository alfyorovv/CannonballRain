using UnityEngine;

public class SpawnClouds : MonoBehaviour
{
    public GameObject cloud;

    private void Start()
    {
        SpawnCloud();
    }

    void SpawnCloud()
    {
        Instantiate(cloud, transform.position, Quaternion.identity);
        Invoke("SpawnCloud", 3f); //Time between spawn
    }
}
