using UnityEngine;

public class LifePowerUpManager : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject powerUpPrefab;
    [SerializeField] private PlayerInmortality player;
    [SerializeField]private int playerLivesAdded = 1;
    private bool collected = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.PlayerLives(playerLivesAdded);

            collected = true;

            animator.SetTrigger("Collected");

            if (collected == true)
            {
                Destroy(powerUpPrefab, 1f);
            }
        }
    }
}
