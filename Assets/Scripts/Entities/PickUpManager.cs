using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject pickUpPrefab;
    [SerializeField] private float spawnTimer = 7;
    [SerializeField] private float despawnTimer = 2;
    [SerializeField] private float pickUpPositionY = -2.5f;
    private float timer;
    private bool collected = false;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTimer)
        {
            float playerPositionX = player.transform.position.x + Random.Range(10f, 30f);

            GameObject i = Instantiate(pickUpPrefab, new Vector3(playerPositionX, pickUpPositionY, 0), transform.rotation);
            Destroy(i, despawnTimer);

            timer = 0;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collected = true;

            animator.SetTrigger("Collected");

            if (collected == true)
            {
                Destroy(pickUpPrefab, 1f);
            }
        }
    }
}
