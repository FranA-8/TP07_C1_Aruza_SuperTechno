using UnityEngine;

public class PlayerInmortality : MonoBehaviour
{
    [SerializeField] private PlayerDataSo data;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject playerLife1;
    [SerializeField] private GameObject playerLife2;
    [SerializeField] private GameObject playerLife3;
    [SerializeField] private GameObject powerUpInmortality;
    [SerializeField] private GameObject powerUpSpeed;
    [SerializeField] private GameObject powerUpJump;
    [SerializeField] private TrailRenderer invencibilityTrail;
    [SerializeField] private ParticleSystem deathParticles;
    [SerializeField] private GameObject gameOverPanel;
    private int playerLives = 1;
    private bool isInmortal = false;
    private float playerPositionX = -2.35f;
    private float playerPositionY = -5.88f;
    private void Start()
    {
        playerLives = data.playerLives;
        if (playerLives == 2)
        {
            playerLife2.SetActive(true);
        }
        else if (playerLives == 3)
        {
            playerLife3.SetActive(true);
            playerLife2.SetActive(true);
        }
        else if (playerLives == 0)
        {
            playerLife1.SetActive(false);
        }
    }
    public void PlayerLives(int value)
    {
        playerLives += value;
        if (playerLives >= 3)
        {
            playerLives = 3;
        }

        if (playerLives == 2)
        {
            playerLife2.SetActive(true);
        }
        else if (playerLives == 3)
        {
            playerLife3.SetActive(true);
        }
    }

    public int GetPlayerLives()
    {
        return playerLives;
    }

    public void IsPlayerInmortal(bool value)
    {
        isInmortal = value;
    }

    public bool GetPlayerInmortal()
    {
        return isInmortal;
    }

    public void InmortalityTrail(bool inmortalTrail)
    {
        invencibilityTrail.enabled = inmortalTrail;
    }

    public void DeathParticles(bool enableParticles)
    {
        deathParticles.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            Destroy(powerUpInmortality, 1f);
        }
        else if (collision.gameObject.CompareTag("PowerUpSpeed"))
        {
            Destroy(powerUpSpeed, 1f);
        }
        else if (collision.gameObject.CompareTag("PowerUpJump"))
        {
            Destroy(powerUpJump, 1f);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (GetPlayerInmortal() == true)
            {
                Destroy(collision.gameObject);   
            }
            else if (GetPlayerLives() == 3)
            {
                Destroy(collision.gameObject);
                playerLives --;
                playerLife3.SetActive(false);

            }
            else if (GetPlayerLives() == 2)
            {
                Destroy(collision.gameObject);
                playerLives--;
                playerLife2.SetActive(false);
            }
            else if (GetPlayerLives() == 1)
            {
                deathParticles.Play();
                player.transform.position = new Vector2(playerPositionX, playerPositionY);
                playerLife1.SetActive(false);
                playerLife1.SetActive(true);
                Time.timeScale = 0f;
                gameOverPanel.SetActive(true);
            }
        }
    }
}
