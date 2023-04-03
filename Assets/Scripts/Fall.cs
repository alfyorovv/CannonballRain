using UnityEngine;

public class Fall : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed;

    private void Awake()
    {
        fallSpeed = 5f;
    }
    private void Update()
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
            Score.score++;
        }

        if (Score.score > 50)
        {
            fallSpeed = 15f;
            SpawnBombs.time = 0.4f;
        }
        else if (Score.score > 25)
        {
            fallSpeed = 12f;
            SpawnBombs.time = 0.5f;
        }
        else if (Score.score > 10)
            fallSpeed = 8f;

        transform.position -= new Vector3(0, fallSpeed*Time.deltaTime,0);

        if(Player.lose==true)
            Destroy(gameObject);
    }

}
