using UnityEngine;

public class PowerUpsGenerator : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject powerUpPrefab;
    [SerializeField] private float spawnTimer = 7;
    [SerializeField] private float despawnTimer = 2;
    [SerializeField] private float powerUpPositionY = -2.5f;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTimer)
        {
            float playerPositionX = player.transform.position.x + Random.Range(10f, 30f);

            GameObject i = Instantiate(powerUpPrefab, new Vector3(playerPositionX, powerUpPositionY, 0), transform.rotation);
            Destroy(i, despawnTimer);

            timer = 0;
        }

    }

}
