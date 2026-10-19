using UnityEngine;

public class JumpPowerUpManager : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject powerUpPrefab;
    [SerializeField] private PlayerJump player;
    [SerializeField] private float powerUpJump;
    private float powerUpJumpTimer = 5;
    private float timer;
    private bool collected = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            player.PowerUpJumpForce(powerUpJump);

            collected = true;

            animator.SetTrigger("Collected");

            timer = powerUpJumpTimer;
        }
    }

    private void Update()
    {
        if (collected == true)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                player.PowerUpJumpForce(-powerUpJump);

                collected = false;

                timer = powerUpJumpTimer;
            }
        }
    }
}
