using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour
{
    public GameObject bomb;
    public static float time;

    private void Awake()
    {
        time = 0.8f;
    }
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-2.3f, 2.3f), 5.3f), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }    
}
