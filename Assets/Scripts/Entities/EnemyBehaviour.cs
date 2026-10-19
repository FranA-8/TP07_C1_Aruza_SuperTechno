using UnityEngine;
using UnityEngine.UI;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    private float health = 0f;
    [SerializeField] private Image healthBar;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnTimer = 3;
    [SerializeField] private float despawnTimer = 10;
    [SerializeField] private ParticleSystem deathParticles;
    private float enemyPositionY = -6f;
    private float timer;

    private void Start()
    {
        healthBar.fillAmount = 1f;
        health = maxHealth;
    }
    public void DeathParticles(bool enableParticles)
    {
        deathParticles.Play();
    }
    public void DoDamage(float amount)
    {
        health -= amount;
        healthBar.fillAmount = health / maxHealth;
        if (health <= 0)
        {
            deathParticles.Play();
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject, 1f);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTimer)
        {
            float playerPositionX = player.transform.position.x + Random.Range(15f, 35f);

            GameObject i = Instantiate(enemyPrefab, new Vector3(playerPositionX, enemyPositionY, 0), transform.rotation);
            Destroy(i, despawnTimer);

            timer = 0;
        }

    }
}
