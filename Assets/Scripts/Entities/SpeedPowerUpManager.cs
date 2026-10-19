using UnityEngine;

public class SpeedPowerUpManager : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject powerUpPrefab;
    [SerializeField] private PlayerMovement player;
    [SerializeField] private float powerUpSpeed;
    private float powerUpSpeedTimer = 5;
    private bool collected = false;
    private float timer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.PowerUpMoveSpeed(powerUpSpeed);

            collected = true;

            animator.SetTrigger("Collected");

            timer = powerUpSpeedTimer;
        }
    }

    private void Update()
    {
        if (collected == true)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                player.PowerUpMoveSpeed(-powerUpSpeed);

                collected = false;

                timer = powerUpSpeedTimer;
            }
        }
    }
}
