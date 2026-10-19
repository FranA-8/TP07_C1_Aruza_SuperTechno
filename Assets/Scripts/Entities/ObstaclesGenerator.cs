using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float spawnTimer = 3;
    [SerializeField] private float despawnTimer = 2;
    [SerializeField] private float obstaclePositionY = -3;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTimer)
        {
            float playerPositionX = player.transform.position.x + Random.Range(15f, 35f);

            GameObject i = Instantiate(obstaclePrefab, new Vector3(playerPositionX, obstaclePositionY, 0), transform.rotation);
            Destroy(i, despawnTimer);

            timer = 0;
        }

    }
}
