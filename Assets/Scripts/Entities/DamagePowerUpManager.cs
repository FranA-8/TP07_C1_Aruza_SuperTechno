using UnityEngine;

public class DamagePowerUpManager : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject powerUpPrefab;
    [SerializeField] private PlayerMovement playerDamage;
    private float powerUpDamage = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerDamage.PowerUpDamage(powerUpDamage);

            animator.SetTrigger("Collected");

        }
    }
}
